using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace pubnHelper
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main(params string[] c)
        {
            foreach (string o in c)
            {
                string[] ss = System.IO.File.ReadAllLines(o);
                System.IO.FileStream fs = System.IO.File.OpenWrite(o);
                System.IO.StreamWriter sw = new System.IO.StreamWriter(fs, System.Text.Encoding.UTF8);
                for (int i = 0; i < ss.Length; i++)
                {
                    sw.WriteLine(ss[i].TrimStart('#'));
                }
                fs.Close();
            }
            MessageBox.Show("成功转换" + c.Length.ToString() + "个文件");
        }
    }
}
