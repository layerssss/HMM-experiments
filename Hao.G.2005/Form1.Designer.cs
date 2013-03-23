namespace Hao.G._2005
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.picOriginal = new System.Windows.Forms.PictureBox();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.picFilterView = new System.Windows.Forms.PictureBox();
            this.numericW1 = new System.Windows.Forms.NumericUpDown();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.numTestAngle = new System.Windows.Forms.NumericUpDown();
            this.textFilterWeights = new System.Windows.Forms.TextBox();
            this.numFilterSize = new System.Windows.Forms.NumericUpDown();
            this.textFilterWeight = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.picFilterOutput = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.picOVHybrid = new System.Windows.Forms.PictureBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.picOVView = new System.Windows.Forms.PictureBox();
            this.numOVSize = new System.Windows.Forms.NumericUpDown();
            this.button3 = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.numRowModels = new System.Windows.Forms.NumericUpDown();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picOriginal)).BeginInit();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFilterView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericW1)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTestAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFilterSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFilterOutput)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picOVHybrid)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picOVView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOVSize)).BeginInit();
            this.tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRowModels)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(12, 48);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(329, 292);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "选择文件夹";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(93, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "上一次选择的文件夹";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Controls.Add(this.tabPage8);
            this.tabControl1.Controls.Add(this.tabPage9);
            this.tabControl1.Location = new System.Drawing.Point(347, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(645, 328);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.picOriginal);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(637, 302);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "图像";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // picOriginal
            // 
            this.picOriginal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.picOriginal.Location = new System.Drawing.Point(0, 0);
            this.picOriginal.Name = "picOriginal";
            this.picOriginal.Size = new System.Drawing.Size(637, 302);
            this.picOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picOriginal.TabIndex = 0;
            this.picOriginal.TabStop = false;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.button5);
            this.tabPage6.Controls.Add(this.picFilterView);
            this.tabPage6.Controls.Add(this.numericW1);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(637, 302);
            this.tabPage6.TabIndex = 3;
            this.tabPage6.Text = "滤波器方向生成";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(81, 43);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 3;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.GetFilterTheta);
            // 
            // picFilterView
            // 
            this.picFilterView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.picFilterView.Location = new System.Drawing.Point(162, 43);
            this.picFilterView.Name = "picFilterView";
            this.picFilterView.Size = new System.Drawing.Size(472, 256);
            this.picFilterView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picFilterView.TabIndex = 2;
            this.picFilterView.TabStop = false;
            // 
            // numericW1
            // 
            this.numericW1.Location = new System.Drawing.Point(39, 14);
            this.numericW1.Name = "numericW1";
            this.numericW1.Size = new System.Drawing.Size(120, 21);
            this.numericW1.TabIndex = 0;
            this.numericW1.Value = new decimal(new int[] {
            13,
            0,
            0,
            0});
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.numTestAngle);
            this.tabPage5.Controls.Add(this.textFilterWeights);
            this.tabPage5.Controls.Add(this.numFilterSize);
            this.tabPage5.Controls.Add(this.textFilterWeight);
            this.tabPage5.Controls.Add(this.button4);
            this.tabPage5.Controls.Add(this.picFilterOutput);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(637, 302);
            this.tabPage5.TabIndex = 2;
            this.tabPage5.Text = "方向滤波";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // numTestAngle
            // 
            this.numTestAngle.Location = new System.Drawing.Point(6, 229);
            this.numTestAngle.Name = "numTestAngle";
            this.numTestAngle.Size = new System.Drawing.Size(75, 21);
            this.numTestAngle.TabIndex = 5;
            this.numTestAngle.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // textFilterWeights
            // 
            this.textFilterWeights.Location = new System.Drawing.Point(6, 93);
            this.textFilterWeights.Multiline = true;
            this.textFilterWeights.Name = "textFilterWeights";
            this.textFilterWeights.ReadOnly = true;
            this.textFilterWeights.Size = new System.Drawing.Size(218, 130);
            this.textFilterWeights.TabIndex = 4;
            // 
            // numFilterSize
            // 
            this.numFilterSize.Location = new System.Drawing.Point(149, 14);
            this.numFilterSize.Name = "numFilterSize";
            this.numFilterSize.Size = new System.Drawing.Size(75, 21);
            this.numFilterSize.TabIndex = 3;
            this.numFilterSize.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // textFilterWeight
            // 
            this.textFilterWeight.Location = new System.Drawing.Point(3, 16);
            this.textFilterWeight.Name = "textFilterWeight";
            this.textFilterWeight.Size = new System.Drawing.Size(140, 21);
            this.textFilterWeight.TabIndex = 2;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(149, 38);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 1;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Filt);
            // 
            // picFilterOutput
            // 
            this.picFilterOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.picFilterOutput.Location = new System.Drawing.Point(230, 0);
            this.picFilterOutput.Name = "picFilterOutput";
            this.picFilterOutput.Size = new System.Drawing.Size(404, 302);
            this.picFilterOutput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picFilterOutput.TabIndex = 0;
            this.picFilterOutput.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.radioButton2);
            this.tabPage2.Controls.Add(this.radioButton1);
            this.tabPage2.Controls.Add(this.tabControl2);
            this.tabPage2.Controls.Add(this.numOVSize);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(637, 302);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "观察向量提取";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(54, 111);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(59, 16);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "从图像";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(54, 89);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(95, 16);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.Text = "从滤波器输出";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Location = new System.Drawing.Point(155, 14);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(476, 282);
            this.tabControl2.TabIndex = 4;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.picOVHybrid);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(468, 256);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "混合图";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // picOVHybrid
            // 
            this.picOVHybrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.picOVHybrid.Location = new System.Drawing.Point(0, 0);
            this.picOVHybrid.Name = "picOVHybrid";
            this.picOVHybrid.Size = new System.Drawing.Size(472, 256);
            this.picOVHybrid.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picOVHybrid.TabIndex = 0;
            this.picOVHybrid.TabStop = false;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.picOVView);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(468, 256);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "提取结果总览";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // picOVView
            // 
            this.picOVView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.picOVView.Location = new System.Drawing.Point(0, 0);
            this.picOVView.Name = "picOVView";
            this.picOVView.Size = new System.Drawing.Size(472, 256);
            this.picOVView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picOVView.TabIndex = 1;
            this.picOVView.TabStop = false;
            // 
            // numOVSize
            // 
            this.numOVSize.Location = new System.Drawing.Point(57, 33);
            this.numOVSize.Name = "numOVSize";
            this.numOVSize.Size = new System.Drawing.Size(92, 21);
            this.numOVSize.TabIndex = 3;
            this.numOVSize.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(57, 60);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "提取观察向量";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.GetObservationVector);
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.numRowModels);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(637, 302);
            this.tabPage7.TabIndex = 4;
            this.tabPage7.Text = "行训练";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // tabPage8
            // 
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(637, 302);
            this.tabPage8.TabIndex = 5;
            this.tabPage8.Text = "全局训练";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // tabPage9
            // 
            this.tabPage9.Location = new System.Drawing.Point(4, 22);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage9.Size = new System.Drawing.Size(637, 302);
            this.tabPage9.TabIndex = 6;
            this.tabPage9.Text = "评估";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // numRowModels
            // 
            this.numRowModels.Location = new System.Drawing.Point(124, 14);
            this.numRowModels.Name = "numRowModels";
            this.numRowModels.Size = new System.Drawing.Size(85, 21);
            this.numRowModels.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 351);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picOriginal)).EndInit();
            this.tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picFilterView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericW1)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTestAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFilterSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFilterOutput)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picOVHybrid)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picOVView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOVSize)).EndInit();
            this.tabPage7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numRowModels)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.PictureBox picOriginal;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox picOVHybrid;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.NumericUpDown numOVSize;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.PictureBox picOVView;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.PictureBox picFilterOutput;
        private System.Windows.Forms.TextBox textFilterWeight;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.NumericUpDown numericW1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.PictureBox picFilterView;
        private System.Windows.Forms.NumericUpDown numFilterSize;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox textFilterWeights;
        private System.Windows.Forms.NumericUpDown numTestAngle;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.TabPage tabPage9;
        private System.Windows.Forms.NumericUpDown numRowModels;
    }
}

