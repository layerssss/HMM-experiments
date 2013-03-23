using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pubnHelper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Link;
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            System.Array paths = ((System.Array)e.Data.GetData(DataFormats.FileDrop));
            foreach (object o in paths)
            {
                string[] ss = System.IO.File.ReadAllLines((string)o);
                System.IO.FileStream fs = System.IO.File.OpenWrite((string)o);
                System.IO.StreamWriter sw = new System.IO.StreamWriter(fs, Encoding.UTF8);
                for (int i = 0; i < ss.Length; i++)
                {
                    sw.WriteLine(ss[i].TrimStart('#'));
                }
                fs.Close();
            }
            
        }
    }
}
