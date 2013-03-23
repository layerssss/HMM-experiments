using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
namespace PicHMM
{
    public partial class ProcessingForm : Form
    {
        public ProcessingForm(Thread t,System.Diagnostics.Process p)
        {
            InitializeComponent();
            this.thread = t;
            this.proc = p;
        }
        System.Diagnostics.Process proc;
        Thread thread;

        private void ProcessingForm_Load(object sender, EventArgs e)
        {
            thread.Start();
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!this.thread.IsAlive)
            {
                this.Close();
            }
        }

        private void ProcessingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.thread.IsAlive)
            {
                this.thread.Abort();
                this.proc.Kill();
            }
        }
    }
}
