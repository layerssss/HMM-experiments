namespace PicHMM
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
            this.listPics = new System.Windows.Forms.ListBox();
            this.butBrowse = new System.Windows.Forms.Button();
            this.tabCtlMain = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textVoiceSaveName = new System.Windows.Forms.TextBox();
            this.butVoiceCapture = new System.Windows.Forms.Button();
            this.numVoiceSR = new System.Windows.Forms.NumericUpDown();
            this.numBps = new System.Windows.Forms.NumericUpDown();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.源图像 = new System.Windows.Forms.TabPage();
            this.picOriginal = new System.Windows.Forms.PictureBox();
            this.预处理结果 = new System.Windows.Forms.TabPage();
            this.picSample = new System.Windows.Forms.PictureBox();
            this.numSampleRate = new System.Windows.Forms.NumericUpDown();
            this.numM = new System.Windows.Forms.NumericUpDown();
            this.butPreprocess = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.butEstimate = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textSaveModelName = new System.Windows.Forms.TextBox();
            this.butSaveModel = new System.Windows.Forms.Button();
            this.butDelModel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.butTrain = new System.Windows.Forms.Button();
            this.numN = new System.Windows.Forms.NumericUpDown();
            this.listDb = new System.Windows.Forms.ListBox();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.tabCtlMain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numVoiceSR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBps)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.源图像.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picOriginal)).BeginInit();
            this.预处理结果.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSample)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSampleRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numM)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numN)).BeginInit();
            this.SuspendLayout();
            // 
            // listPics
            // 
            this.listPics.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.listPics.FormattingEnabled = true;
            this.listPics.ItemHeight = 12;
            this.listPics.Location = new System.Drawing.Point(12, 48);
            this.listPics.Name = "listPics";
            this.listPics.Size = new System.Drawing.Size(219, 316);
            this.listPics.TabIndex = 0;
            this.listPics.SelectedIndexChanged += new System.EventHandler(this.listPics_SelectedIndexChanged);
            // 
            // butBrowse
            // 
            this.butBrowse.Location = new System.Drawing.Point(12, 12);
            this.butBrowse.Name = "butBrowse";
            this.butBrowse.Size = new System.Drawing.Size(219, 23);
            this.butBrowse.TabIndex = 1;
            this.butBrowse.Text = "浏览";
            this.butBrowse.UseVisualStyleBackColor = true;
            this.butBrowse.Click += new System.EventHandler(this.butBrowse_Click);
            // 
            // tabCtlMain
            // 
            this.tabCtlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabCtlMain.Controls.Add(this.tabPage1);
            this.tabCtlMain.Controls.Add(this.tabPage2);
            this.tabCtlMain.Controls.Add(this.tabPage3);
            this.tabCtlMain.Location = new System.Drawing.Point(237, 12);
            this.tabCtlMain.Name = "tabCtlMain";
            this.tabCtlMain.SelectedIndex = 0;
            this.tabCtlMain.Size = new System.Drawing.Size(578, 361);
            this.tabCtlMain.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.textVoiceSaveName);
            this.tabPage1.Controls.Add(this.butVoiceCapture);
            this.tabPage1.Controls.Add(this.numVoiceSR);
            this.tabPage1.Controls.Add(this.numBps);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(570, 335);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "声音";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(132, 13);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(120, 20);
            this.comboBox1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(132, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "装载设备";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textVoiceSaveName
            // 
            this.textVoiceSaveName.Location = new System.Drawing.Point(6, 173);
            this.textVoiceSaveName.Name = "textVoiceSaveName";
            this.textVoiceSaveName.Size = new System.Drawing.Size(120, 21);
            this.textVoiceSaveName.TabIndex = 2;
            this.textVoiceSaveName.TextChanged += new System.EventHandler(this.textVoiceSaveName_TextChanged);
            // 
            // butVoiceCapture
            // 
            this.butVoiceCapture.Enabled = false;
            this.butVoiceCapture.Location = new System.Drawing.Point(6, 200);
            this.butVoiceCapture.Name = "butVoiceCapture";
            this.butVoiceCapture.Size = new System.Drawing.Size(120, 23);
            this.butVoiceCapture.TabIndex = 1;
            this.butVoiceCapture.Text = "开始录制";
            this.butVoiceCapture.UseVisualStyleBackColor = true;
            this.butVoiceCapture.Click += new System.EventHandler(this.butVoiceCapture_Click);
            // 
            // numVoiceSR
            // 
            this.numVoiceSR.Location = new System.Drawing.Point(6, 41);
            this.numVoiceSR.Maximum = new decimal(new int[] {
            22050,
            0,
            0,
            0});
            this.numVoiceSR.Name = "numVoiceSR";
            this.numVoiceSR.Size = new System.Drawing.Size(120, 21);
            this.numVoiceSR.TabIndex = 0;
            this.numVoiceSR.Value = new decimal(new int[] {
            11025,
            0,
            0,
            0});
            // 
            // numBps
            // 
            this.numBps.Location = new System.Drawing.Point(6, 14);
            this.numBps.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.numBps.Name = "numBps";
            this.numBps.Size = new System.Drawing.Size(120, 21);
            this.numBps.TabIndex = 0;
            this.numBps.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tabControl1);
            this.tabPage2.Controls.Add(this.numSampleRate);
            this.tabPage2.Controls.Add(this.numM);
            this.tabPage2.Controls.Add(this.butPreprocess);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(570, 335);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "图像";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.源图像);
            this.tabControl1.Controls.Add(this.预处理结果);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(435, 326);
            this.tabControl1.TabIndex = 3;
            // 
            // 源图像
            // 
            this.源图像.Controls.Add(this.picOriginal);
            this.源图像.Location = new System.Drawing.Point(4, 22);
            this.源图像.Name = "源图像";
            this.源图像.Padding = new System.Windows.Forms.Padding(3);
            this.源图像.Size = new System.Drawing.Size(427, 300);
            this.源图像.TabIndex = 0;
            this.源图像.Text = "源图像";
            this.源图像.UseVisualStyleBackColor = true;
            // 
            // picOriginal
            // 
            this.picOriginal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.picOriginal.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.picOriginal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picOriginal.Location = new System.Drawing.Point(0, 0);
            this.picOriginal.Name = "picOriginal";
            this.picOriginal.Size = new System.Drawing.Size(427, 300);
            this.picOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picOriginal.TabIndex = 0;
            this.picOriginal.TabStop = false;
            // 
            // 预处理结果
            // 
            this.预处理结果.Controls.Add(this.picSample);
            this.预处理结果.Location = new System.Drawing.Point(4, 22);
            this.预处理结果.Name = "预处理结果";
            this.预处理结果.Padding = new System.Windows.Forms.Padding(3);
            this.预处理结果.Size = new System.Drawing.Size(427, 300);
            this.预处理结果.TabIndex = 1;
            this.预处理结果.Text = "预处理结果";
            this.预处理结果.UseVisualStyleBackColor = true;
            // 
            // picSample
            // 
            this.picSample.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.picSample.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.picSample.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picSample.Location = new System.Drawing.Point(0, 0);
            this.picSample.Name = "picSample";
            this.picSample.Size = new System.Drawing.Size(427, 300);
            this.picSample.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picSample.TabIndex = 0;
            this.picSample.TabStop = false;
            // 
            // numSampleRate
            // 
            this.numSampleRate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.numSampleRate.Location = new System.Drawing.Point(444, 22);
            this.numSampleRate.Name = "numSampleRate";
            this.numSampleRate.Size = new System.Drawing.Size(120, 21);
            this.numSampleRate.TabIndex = 2;
            this.numSampleRate.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // numM
            // 
            this.numM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.numM.Location = new System.Drawing.Point(444, 49);
            this.numM.Name = "numM";
            this.numM.Size = new System.Drawing.Size(120, 21);
            this.numM.TabIndex = 2;
            this.numM.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // butPreprocess
            // 
            this.butPreprocess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butPreprocess.Location = new System.Drawing.Point(444, 76);
            this.butPreprocess.Name = "butPreprocess";
            this.butPreprocess.Size = new System.Drawing.Size(120, 23);
            this.butPreprocess.TabIndex = 1;
            this.butPreprocess.Text = "预处理";
            this.butPreprocess.UseVisualStyleBackColor = true;
            this.butPreprocess.Click += new System.EventHandler(this.butPreprocess_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Controls.Add(this.listDb);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(570, 335);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "模型";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox3.Controls.Add(this.butEstimate);
            this.groupBox3.Location = new System.Drawing.Point(149, 237);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(153, 68);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "以数据库中模型评估";
            // 
            // butEstimate
            // 
            this.butEstimate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butEstimate.Location = new System.Drawing.Point(6, 28);
            this.butEstimate.Name = "butEstimate";
            this.butEstimate.Size = new System.Drawing.Size(141, 23);
            this.butEstimate.TabIndex = 4;
            this.butEstimate.Text = "评估选定项";
            this.butEstimate.UseVisualStyleBackColor = true;
            this.butEstimate.Click += new System.EventHandler(this.butEstimate_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.textSaveModelName);
            this.groupBox2.Controls.Add(this.butSaveModel);
            this.groupBox2.Controls.Add(this.butDelModel);
            this.groupBox2.Location = new System.Drawing.Point(448, 226);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(116, 103);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "模型数据库";
            // 
            // textSaveModelName
            // 
            this.textSaveModelName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textSaveModelName.Location = new System.Drawing.Point(8, 18);
            this.textSaveModelName.Name = "textSaveModelName";
            this.textSaveModelName.Size = new System.Drawing.Size(100, 21);
            this.textSaveModelName.TabIndex = 1;
            this.textSaveModelName.TextChanged += new System.EventHandler(this.textSaveModelName_TextChanged);
            // 
            // butSaveModel
            // 
            this.butSaveModel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butSaveModel.Enabled = false;
            this.butSaveModel.Location = new System.Drawing.Point(6, 45);
            this.butSaveModel.Name = "butSaveModel";
            this.butSaveModel.Size = new System.Drawing.Size(102, 23);
            this.butSaveModel.TabIndex = 2;
            this.butSaveModel.Text = "保存训练结果";
            this.butSaveModel.UseVisualStyleBackColor = true;
            this.butSaveModel.Click += new System.EventHandler(this.butSaveModel_Click);
            // 
            // butDelModel
            // 
            this.butDelModel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butDelModel.Location = new System.Drawing.Point(6, 74);
            this.butDelModel.Name = "butDelModel";
            this.butDelModel.Size = new System.Drawing.Size(102, 23);
            this.butDelModel.TabIndex = 3;
            this.butDelModel.Text = "删除选定项";
            this.butDelModel.UseVisualStyleBackColor = true;
            this.butDelModel.Click += new System.EventHandler(this.butDelModel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.butTrain);
            this.groupBox1.Controls.Add(this.numN);
            this.groupBox1.Location = new System.Drawing.Point(6, 237);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(137, 92);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "训练新模型";
            // 
            // butTrain
            // 
            this.butTrain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.butTrain.Location = new System.Drawing.Point(11, 56);
            this.butTrain.Name = "butTrain";
            this.butTrain.Size = new System.Drawing.Size(120, 23);
            this.butTrain.TabIndex = 3;
            this.butTrain.Text = "加载并训练";
            this.butTrain.UseVisualStyleBackColor = true;
            this.butTrain.Click += new System.EventHandler(this.butTrain_Click);
            // 
            // numN
            // 
            this.numN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.numN.Location = new System.Drawing.Point(11, 30);
            this.numN.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.numN.Name = "numN";
            this.numN.Size = new System.Drawing.Size(120, 21);
            this.numN.TabIndex = 4;
            this.numN.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // listDb
            // 
            this.listDb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listDb.FormattingEnabled = true;
            this.listDb.ItemHeight = 12;
            this.listDb.Location = new System.Drawing.Point(6, 14);
            this.listDb.Name = "listDb";
            this.listDb.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listDb.Size = new System.Drawing.Size(558, 196);
            this.listDb.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 105);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "播放";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 379);
            this.Controls.Add(this.tabCtlMain);
            this.Controls.Add(this.butBrowse);
            this.Controls.Add(this.listPics);
            this.MinimumSize = new System.Drawing.Size(740, 342);
            this.Name = "Form1";
            this.Text = "HMM图像识别测试";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabCtlMain.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numVoiceSR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBps)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.源图像.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picOriginal)).EndInit();
            this.预处理结果.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picSample)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSampleRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numM)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numN)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listPics;
        private System.Windows.Forms.Button butBrowse;
        private System.Windows.Forms.TabControl tabCtlMain;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListBox listDb;
        private System.Windows.Forms.PictureBox picOriginal;
        private System.Windows.Forms.NumericUpDown numN;
        private System.Windows.Forms.Button butTrain;
        private System.Windows.Forms.NumericUpDown numM;
        private System.Windows.Forms.Button butPreprocess;
        private System.Windows.Forms.PictureBox picSample;
        private System.Windows.Forms.Button butEstimate;
        private System.Windows.Forms.Button butDelModel;
        private System.Windows.Forms.Button butSaveModel;
        private System.Windows.Forms.TextBox textSaveModelName;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage 源图像;
        private System.Windows.Forms.TabPage 预处理结果;
        private System.Windows.Forms.NumericUpDown numSampleRate;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox textVoiceSaveName;
        private System.Windows.Forms.Button butVoiceCapture;
        private System.Windows.Forms.NumericUpDown numVoiceSR;
        private System.Windows.Forms.NumericUpDown numBps;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
    }
}

