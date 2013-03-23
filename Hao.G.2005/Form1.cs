using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using PrePocessing;
using LUtil;

namespace Hao.G._2005
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                listBox1.Items.Clear();
                listBox1.Items.AddRange(Directory.GetFiles(folderBrowserDialog1.SelectedPath));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Clear();
                listBox1.Items.AddRange(Directory.GetFiles(folderBrowserDialog1.SelectedPath));
            }
            catch { };
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            File.WriteAllText("dbpath.txt", folderBrowserDialog1.SelectedPath);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                folderBrowserDialog1.SelectedPath = File.ReadAllText("dbpath.txt");
            }
            catch { }
        }
        double[][] filterTheta;
        private void GetObservationVector(object sender, EventArgs e)
        {
            Bitmap img,img2;
            if (radioButton1.Checked)
            {
                picOVHybrid.Image = img = new Bitmap(picFilterOutput.Image);
            }
            else
            {
                picOVHybrid.Image = img = new Bitmap(picOriginal.Image);
            }
            picOVView.Image = img2 = new Bitmap(img.Width, img.Height);
            Graphics a = Graphics.FromImage(img);
            Graphics a2 = Graphics.FromImage(img2);
            Pen redPen=new Pen(Color.Red,1);
            Pen greenPen = new Pen(Color.Green,1);
            Pen blackPen = new Pen(Color.Black, 1);
            ObservationVector o = new ObservationVector();
            int w=(int)numOVSize.Value;
            o.OrientationField = Matrix<double>.GetNew(w, w);
            for (int ibase = 0; ibase + w < img.Height; ibase += w)
            {
                for (int jbase = 0; jbase + w < img.Width; jbase += w)
                {
                    for (int i = 0; i < w; i++)
                    {
                        for (int j = 0; j < w; j++)
                        {
                            o.OrientationField[j][i]=img.GetPixel(jbase + j, ibase + i).GetBrightness();
                        }
                    }
                    double theta = Math.PI / 2 - o.GetTheta();
                    int recordtheta = (int)(theta /Math.PI * 18);
                    theta = Math.Tan(theta);
                    if (theta > 0)
                    {
                        if (theta < 1)
                        {
                            a.DrawLine(redPen, jbase + w, ibase, jbase, ibase + (int)Math.Floor(w * theta));
                            a2.DrawLine(blackPen, jbase + w, ibase, jbase, ibase + (int)Math.Floor(w * theta));
                        }
                        else//theta >1
                        {
                            a.DrawLine(redPen, jbase + w, ibase, jbase + w - (int)Math.Floor(w / theta), ibase + w);
                            a2.DrawLine(blackPen, jbase + w, ibase, jbase + w - (int)Math.Floor(w / theta), ibase + w);
                        }
                    }
                    else
                    {
                        theta = -theta;
                        if (theta < 1)
                        {
                            a.DrawLine(redPen, jbase, ibase, jbase + w , ibase + (int)Math.Floor(w * theta));
                            a2.DrawLine(blackPen, jbase, ibase, jbase + w, ibase + (int)Math.Floor(w * theta));
                        }
                        else
                        {
                            a.DrawLine(redPen, jbase, ibase , jbase+ (int)Math.Floor(w / theta), ibase + w );
                            a2.DrawLine(blackPen, jbase, ibase, jbase + (int)Math.Floor(w / theta), ibase + w);
                        }
                    }
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                picOriginal.Load((string)listBox1.SelectedItem);
            }
        }
        double[][] filter;
        private void Filt(object sender, EventArgs e)
        {
            int s=(int)numFilterSize.Value;
            
            double[] weight = new double[s];
            this.filter = new double[s + s - 1][];
            string[] ss = textFilterWeight.Text.Split(' ');
            Array.ConvertAll<string, double>(ss, new Converter<string, double>(ts => double.Parse(ts))).CopyTo(weight,0);
            for (int i = 0; i < filter.Length; i++)
            {
                this.filter[i] = new double[s + s - 1];
            }

            #region TEST
            BuildFilter(this.filter, ((double)numTestAngle.Value) / 180 * Math.PI, weight);
            textFilterWeights.Text = "";
            for (int i = 0; i < filter.Length; i++)
            {
                for (int j = 0; j < filter[i].Length; j++)
                {
                    textFilterWeights.Text += filter[i][j];
                }
                textFilterWeights.Text += "\r\n";
            } 
            #endregion
            Bitmap oldimg = (Bitmap) picOriginal.Image;
            Bitmap newpic = new Bitmap(oldimg.Width, oldimg.Height);
            try
            {
                for (int x = s - 1; x < this.filterTheta[0].Length; x++)
                {
                    for (int y = s - 1; y < this.filterTheta.Length; y++)
                    {
                        BuildFilter(this.filter, this.filterTheta[y][x], weight);
                        #region op
                        double sum = 0;
                        for (int i = -filter.Length / 2; i <= filter.Length / 2; i++)
                        {
                            for (int j = -filter[0].Length / 2; j <= filter[0].Length / 2; j++)
                            {
                                sum += filter[filter.Length / 2 + i][filter.Length / 2 + j] * oldimg.GetPixel(x + j, y + i).GetBrightness();
                            }
                        }
                        newpic.SetPixel(x, y, Color.FromArgb((int)(255 * sum), (int)(255 * sum), (int)(255 * sum)));
                        #endregion
                    }
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message, ee.Source + "\r\n" + ee.StackTrace, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            picFilterOutput.Image = newpic;
        }
        void BuildFilter(double[][] filter, double theta, double[] weight)
        {
            double l;
            for (int i = 0; i < filter.Length; i++)
            {
                for (int j = 0; j < filter[i].Length; j++)
                {
                    l = (j - weight.Length + 1) * Math.Sin(theta) - (i - weight.Length + 1) * Math.Cos(theta);
                    l = Math.Floor(Math.Abs(l));
                    if (l < weight.Length)
                    {
                        filter[i][j] = weight[weight.Length - 1 - (int)l];
                    }
                    else
                    {
                        filter[i][j] = 0;
                    }
                }
            }
        }
        private void GetFilterTheta(object sender, EventArgs e)
        {
            Bitmap img;
            picFilterView.Image = img = new Bitmap(picOriginal.Image.Width, picOriginal.Image.Height);
            Graphics a = Graphics.FromImage(img);
            Pen blackPen = new Pen(Color.Black, 1);
            ObservationVector o = new ObservationVector();
            int w = (int)numericW1.Value;
            o.OrientationField = Matrix<double>.GetNew(w, w);
            this.filterTheta=new double[img.Height-img.Height % w-w][];
            for (int i = 0; i < img.Height - img.Height % w-w; i++)
            {
                this.filterTheta[i] = new double[img.Width - img.Width % w];
            }
            for (int ibase = 0; ibase + w < img.Height; ibase += w)
            {
                for (int jbase = 0; jbase + w < img.Width; jbase += w)
                {
                    for (int i = 0; i < w; i++)
                    {
                        for (int j = 0; j < w; j++)
                        {
                            o.OrientationField[j][i] = ((Bitmap) picOriginal.Image).GetPixel(jbase + j, ibase + i).GetBrightness();
                        }
                    }
                    double theta = Math.PI / 2 - o.GetTheta();
                    for (int i = 0; i < w; i++)
                    {
                        for (int j = 0; j < w; j++)
                        {
                            this.filterTheta[i][j] = theta;
                        }
                    }
                    theta = Math.Tan(theta);
                    if (theta > 0)
                    {
                        if (theta < 1)
                        {
                            a.DrawLine(blackPen, jbase + w, ibase, jbase, ibase + (int)Math.Floor(w * theta));
                        }
                        else//theta >1
                        {
                            a.DrawLine(blackPen, jbase + w, ibase, jbase + w - (int)Math.Floor(w / theta), ibase + w);
                        }
                    }
                    else
                    {
                        theta = -theta;
                        if (theta < 1)
                        {
                            a.DrawLine(blackPen, jbase, ibase, jbase + w, ibase + (int)Math.Floor(w * theta));
                        }
                        else
                        {
                            a.DrawLine(blackPen, jbase, ibase, jbase + (int)Math.Floor(w / theta), ibase + w);
                        }
                    }
                }
            }
        }
    }
}
