using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;
namespace PicHMM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void butBrowse_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                listPicsRefresh();
            }
        }
        void listPicsRefresh()
        {
            listPics.Items.Clear();
            string[] ss = Directory.GetFiles(folderBrowserDialog.SelectedPath);
            foreach (string s in ss)
            {
                listPics.Items.Add(s.Substring(s.LastIndexOf('\\') + 1));
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            refreshHMMs();
            try
            {
                folderBrowserDialog.SelectedPath = File.ReadAllText("picspath.txt");
                listPicsRefresh();
            }
            catch { }

            vc = new LayersSssCode.Voice.VoiceCapture();
            string[] devnames = vc.GetCaptureDevices();
            comboBox1.Items.AddRange(devnames);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            File.WriteAllText("picspath.txt", folderBrowserDialog.SelectedPath);
        }
        byte[] buffer;
        private void listPics_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                textSaveModelName.Text = (string)listPics.SelectedItem;
                textSaveModelName.Text = textSaveModelName.Text.Remove(textSaveModelName.Text.LastIndexOf('.'));
                picOriginal.Load(folderBrowserDialog.SelectedPath + "\\" + (string)listPics.SelectedItem);
                tabCtlMain.SelectTab(tabPage2);
                tabControl1.SelectTab(源图像);
            }
            catch
            {
                try
                {
                    buffer = File.ReadAllBytes(folderBrowserDialog.SelectedPath + "\\" + (string)listPics.SelectedItem);
                    StreamWriter sw = File.CreateText("Hmm3Test_O1.txt");
                    for (int i = 1; i < buffer.Length; i++)
                    {
                        sw.Write(" ");
                        sw.Write((buffer[i] + 1).ToString());
                    }
                    sw.Close();

                    File.WriteAllText("Hmm3Test_M.txt", "129");
                    tabCtlMain.SelectTab(tabPage1);
                }
                catch { }
            }
        }
        int[] sample;
        private void butPreprocess_Click(object sender, EventArgs e)
        {
            float brightness;
            int result;
            int N = (int)numM.Value;
            Bitmap picOld = new Bitmap(
                this.picOriginal.Image, 
                new Size(
                    this.picOriginal.Image.Width/(int)this.numSampleRate.Value,
                    this.picOriginal.Image.Height/(int)this.numSampleRate.Value));
            int width = picOld.Width;
            int height = picOld.Height;
            Bitmap picNew = new Bitmap(width, height);
            this.sample = new int[width * height];
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    brightness = picOld.GetPixel(x, y).GetBrightness();
                    this.sample[y * width + x] = result = (int)(brightness * (N-1))+1;
                    brightness=(float)(result-1) / (N-1);
                    picNew.SetPixel(x, y, Color.FromArgb((int)(255 * brightness), (int)(255 * brightness), (int)(255 * brightness)));
                }
            }
            Bitmap showpic=new Bitmap(this.picOriginal.Image.Width,this.picOriginal.Image.Height);
            Graphics g=Graphics.FromImage(showpic);
            //System.Drawing.Drawing2D.InterpolationMode.
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
            g.DrawImage(picNew, new Rectangle(Point.Empty, showpic.Size), new Rectangle(Point.Empty, picNew.Size), GraphicsUnit.Pixel);



            File.WriteAllText("Hmm3Test_M.txt", numM.Value.ToString());

            StreamWriter sw = File.CreateText("Hmm3Test_O1.txt");
            sw.Write(this.sample[0].ToString());
            for (int i = 1; i < this.sample.Length; i++)
            {
                sw.Write(" ");
                sw.Write(this.sample[i].ToString());
            }
            sw.Close();


            
            this.picSample.Image = showpic;
            this.tabControl1.SelectTab(this.预处理结果);

        }

        private void butTrain_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            Thread t = new Thread(this.trainHMM);
            ProcessingForm f = new ProcessingForm(t,this.proc);
            f.ShowDialog();
            this.Enabled = true;
            try
            {
                this.proc.Kill();
            }
            catch { }

            refreshHMMs();
        }
        public System.Diagnostics.Process proc = new System.Diagnostics.Process();
        void trainHMM()
        {
            File.WriteAllText("Hmm3Test_N.txt", numN.Value.ToString());
            


            proc.StartInfo.CreateNoWindow = true;
            proc.StartInfo.UseShellExecute = false;


            proc.StartInfo.FileName = "Hmm3Test.exe";
            proc.StartInfo.Arguments = " -i Hmm3Test_N.txt Hmm3Test_M.txt Hmm3Test_hmm.txt";
            proc.Start();
            proc.WaitForExit();

            proc.StartInfo.FileName = "Hmm3Test.exe";
            proc.StartInfo.Arguments = " -t Hmm3Test_O1.txt Hmm3Test_hmm.txt";
            proc.Start();
            proc.WaitForExit();


            proc.StartInfo.FileName = "Hmm3Test.exe";
            proc.StartInfo.Arguments = " -e Hmm3Test_O1.txt Hmm3Test_hmm.txt Hmm3Test_pprob.txt";
            proc.Start();
            proc.WaitForExit();

            MessageBox.Show("Likelihood:" + File.ReadAllText("Hmm3Test_pprob.txt"), "训练完毕", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            
        }

        private void butSaveModel_Click(object sender, EventArgs e)
        {
            try
            {
                File.Copy(Application.StartupPath + "\\Hmm3Test_hmm.txt", Application.StartupPath + "\\hmms\\" + textSaveModelName.Text + ".txt");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            refreshHMMs();
        }

        private void butDelModel_Click(object sender, EventArgs e)
        {
            foreach (string s in listDb.SelectedItems)
            {
                if (s.Contains(":"))
                {
                    deleteHMM(s.Remove(s.LastIndexOf(':')));
                }
                else
                {
                    deleteHMM(s);
                }
            }
            refreshHMMs();
        }
        void deleteHMM(string name)
        {
            File.Delete(Application.StartupPath + "\\hmms\\" + name + ".txt");
        }
        void refreshHMMs()
        {
            string s2;
            listDb.Items.Clear();
            string[] ss = Directory.GetFiles(Application.StartupPath + "\\hmms");
            foreach (string s in ss)
            {
                s2 = s.Remove(s.LastIndexOf('.'));
                s2 = s2.Substring(s2.LastIndexOf('\\')+1);
                listDb.Items.Add(s2);
            }
        }
        string estimateHMM(string name)
        {
            File.Copy("hmms\\" + name + ".txt", "Hmm3Test_hmm.txt",true);

            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo.CreateNoWindow = true;
            proc.StartInfo.UseShellExecute = false;


            proc.StartInfo.FileName = "Hmm3Test.exe";
            proc.StartInfo.Arguments = " -e Hmm3Test_O1.txt Hmm3Test_hmm.txt Hmm3Test_pprob.txt";
            proc.Start();
            proc.WaitForExit();

            return File.ReadAllText("Hmm3Test_pprob.txt");
        }
        private void textSaveModelName_TextChanged(object sender, EventArgs e)
        {
            this.butSaveModel.Enabled = ((TextBox)sender).Text.Length > 0;
        }

        private void butEstimate_Click(object sender, EventArgs e)
        {
            string s;
            foreach (int i in listDb.SelectedIndices)
            {
                s = (string)listDb.Items[i];
                if (s.Contains(":"))
                {
                    s=s.Remove(s.LastIndexOf(':'));
                }
                listDb.Items[i] =s+": likelihood="+estimateHMM(s);
            }
        }

        private void textVoiceSaveName_TextChanged(object sender, EventArgs e)
        {
            butVoiceCapture.Enabled = textVoiceSaveName.Text.Length != 0;
        }
        LayersSssCode.Voice.VoiceCapture vc;
        MemoryStream ms;
        private void butVoiceCapture_Click(object sender, EventArgs e)
        {
            if (butVoiceCapture.Text == "开始录制")
            {
                textVoiceSaveName.Enabled = false;
                butVoiceCapture.Text = "停止录制";
                
                ms = new MemoryStream();
                vc.OutputStream = ms;
                vc.StartVoiceCapture();
            }
            else
            {
                vc.Stop();
                ms.Close();
                byte[] buffer=ms.GetBuffer();
                File.WriteAllBytes(folderBrowserDialog.SelectedPath + "\\" + textVoiceSaveName.Text + ".voice",buffer);


                textVoiceSaveName.Enabled = true;
                butVoiceCapture.Text = "开始录制";
                listPicsRefresh();
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vc.NotifyNum = 2;
            vc.NotifySize = 250;
            vc.Intptr = this.Handle;
            vc.InitVoice(comboBox1.Text, (int)numVoiceSR.Value, (short)numBps.Value);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            vc.GetVoiceData(buffer.Length, buffer);
        }
    }
}
