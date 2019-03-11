namespace VideoCutGUI
{
    partial class frmMain
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("此处显示已完成文件");
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lblNum = new System.Windows.Forms.Label();
            this.btnDir = new System.Windows.Forms.Button();
            this.btnFile = new System.Windows.Forms.Button();
            this.gbLog = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lstFinished = new System.Windows.Forms.ListView();
            this.gbSave = new System.Windows.Forms.GroupBox();
            this.gbMethod = new System.Windows.Forms.GroupBox();
            this.rdbAll = new System.Windows.Forms.RadioButton();
            this.rdbEach = new System.Windows.Forms.RadioButton();
            this.btnSave = new System.Windows.Forms.Button();
            this.gbFreq = new System.Windows.Forms.GroupBox();
            this.rdbdotfive = new System.Windows.Forms.RadioButton();
            this.rdbThreeSec = new System.Windows.Forms.RadioButton();
            this.rdbOneSec = new System.Windows.Forms.RadioButton();
            this.rdbFiveSec = new System.Windows.Forms.RadioButton();
            this.bgwVideo = new System.ComponentModel.BackgroundWorker();
            this.bgwFileLoading = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.gbLog.SuspendLayout();
            this.gbSave.SuspendLayout();
            this.gbMethod.SuspendLayout();
            this.gbFreq.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lblNum);
            this.splitContainer1.Panel1.Controls.Add(this.btnDir);
            this.splitContainer1.Panel1.Controls.Add(this.btnFile);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gbLog);
            this.splitContainer1.Panel2.Controls.Add(this.gbSave);
            this.splitContainer1.Panel2.Controls.Add(this.gbFreq);
            this.splitContainer1.Size = new System.Drawing.Size(819, 552);
            this.splitContainer1.SplitterDistance = 146;
            this.splitContainer1.TabIndex = 0;
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(345, 134);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(107, 12);
            this.lblNum.TabIndex = 2;
            this.lblNum.Text = "当前已选定0个文件";
            // 
            // btnDir
            // 
            this.btnDir.Location = new System.Drawing.Point(508, 32);
            this.btnDir.Name = "btnDir";
            this.btnDir.Size = new System.Drawing.Size(140, 91);
            this.btnDir.TabIndex = 1;
            this.btnDir.Text = "选择目录";
            this.btnDir.UseVisualStyleBackColor = true;
            this.btnDir.Click += new System.EventHandler(this.btnDir_Click);
            // 
            // btnFile
            // 
            this.btnFile.Location = new System.Drawing.Point(152, 32);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(140, 91);
            this.btnFile.TabIndex = 0;
            this.btnFile.Text = "选择文件";
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // gbLog
            // 
            this.gbLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbLog.Controls.Add(this.btnCancel);
            this.gbLog.Controls.Add(this.btnStart);
            this.gbLog.Controls.Add(this.lblStatus);
            this.gbLog.Controls.Add(this.lstFinished);
            this.gbLog.Location = new System.Drawing.Point(458, 36);
            this.gbLog.Name = "gbLog";
            this.gbLog.Size = new System.Drawing.Size(349, 354);
            this.gbLog.TabIndex = 3;
            this.gbLog.TabStop = false;
            this.gbLog.Text = "处理日志";
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Location = new System.Drawing.Point(246, 310);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(97, 38);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "取消操作";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(6, 310);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(97, 38);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "开始切图";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(6, 26);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(77, 12);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "尚未开始抽取";
            // 
            // lstFinished
            // 
            this.lstFinished.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.lstFinished.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstFinished.GridLines = true;
            this.lstFinished.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem4});
            this.lstFinished.Location = new System.Drawing.Point(6, 52);
            this.lstFinished.Name = "lstFinished";
            this.lstFinished.Size = new System.Drawing.Size(337, 252);
            this.lstFinished.TabIndex = 0;
            this.lstFinished.UseCompatibleStateImageBehavior = false;
            this.lstFinished.View = System.Windows.Forms.View.List;
            // 
            // gbSave
            // 
            this.gbSave.Controls.Add(this.gbMethod);
            this.gbSave.Controls.Add(this.btnSave);
            this.gbSave.Location = new System.Drawing.Point(205, 31);
            this.gbSave.Name = "gbSave";
            this.gbSave.Size = new System.Drawing.Size(247, 359);
            this.gbSave.TabIndex = 2;
            this.gbSave.TabStop = false;
            this.gbSave.Text = "选择保存方式";
            // 
            // gbMethod
            // 
            this.gbMethod.Controls.Add(this.rdbAll);
            this.gbMethod.Controls.Add(this.rdbEach);
            this.gbMethod.Location = new System.Drawing.Point(12, 208);
            this.gbMethod.Name = "gbMethod";
            this.gbMethod.Size = new System.Drawing.Size(229, 135);
            this.gbMethod.TabIndex = 3;
            this.gbMethod.TabStop = false;
            this.gbMethod.Text = "选择如何保存图片";
            // 
            // rdbAll
            // 
            this.rdbAll.AutoSize = true;
            this.rdbAll.Checked = true;
            this.rdbAll.Cursor = System.Windows.Forms.Cursors.Default;
            this.rdbAll.Location = new System.Drawing.Point(21, 20);
            this.rdbAll.Name = "rdbAll";
            this.rdbAll.Size = new System.Drawing.Size(155, 16);
            this.rdbAll.TabIndex = 1;
            this.rdbAll.TabStop = true;
            this.rdbAll.Text = "全部保存在一个文件夹里";
            this.rdbAll.UseVisualStyleBackColor = true;
            this.rdbAll.CheckedChanged += new System.EventHandler(this.rdbAll_CheckedChanged);
            // 
            // rdbEach
            // 
            this.rdbEach.AutoSize = true;
            this.rdbEach.Location = new System.Drawing.Point(21, 42);
            this.rdbEach.Name = "rdbEach";
            this.rdbEach.Size = new System.Drawing.Size(191, 16);
            this.rdbEach.TabIndex = 2;
            this.rdbEach.Text = "为每个视频文件单独建立文件夹";
            this.rdbEach.UseVisualStyleBackColor = true;
            this.rdbEach.CheckedChanged += new System.EventHandler(this.rdbEach_CheckedChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(65, 57);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(111, 55);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "选择保存路径";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // gbFreq
            // 
            this.gbFreq.Controls.Add(this.rdbdotfive);
            this.gbFreq.Controls.Add(this.rdbThreeSec);
            this.gbFreq.Controls.Add(this.rdbOneSec);
            this.gbFreq.Controls.Add(this.rdbFiveSec);
            this.gbFreq.Location = new System.Drawing.Point(12, 31);
            this.gbFreq.Name = "gbFreq";
            this.gbFreq.Size = new System.Drawing.Size(187, 359);
            this.gbFreq.TabIndex = 1;
            this.gbFreq.TabStop = false;
            this.gbFreq.Text = "选择切图频率";
            // 
            // rdbdotfive
            // 
            this.rdbdotfive.AutoSize = true;
            this.rdbdotfive.Location = new System.Drawing.Point(40, 46);
            this.rdbdotfive.Name = "rdbdotfive";
            this.rdbdotfive.Size = new System.Drawing.Size(113, 16);
            this.rdbdotfive.TabIndex = 3;
            this.rdbdotfive.Text = "每0.5秒切一张图";
            this.rdbdotfive.UseVisualStyleBackColor = true;
            this.rdbdotfive.CheckedChanged += new System.EventHandler(this.rdbdotfive_CheckedChanged);
            // 
            // rdbThreeSec
            // 
            this.rdbThreeSec.AutoSize = true;
            this.rdbThreeSec.Location = new System.Drawing.Point(40, 159);
            this.rdbThreeSec.Name = "rdbThreeSec";
            this.rdbThreeSec.Size = new System.Drawing.Size(101, 16);
            this.rdbThreeSec.TabIndex = 2;
            this.rdbThreeSec.Text = "每3秒切一张图";
            this.rdbThreeSec.UseVisualStyleBackColor = true;
            this.rdbThreeSec.CheckedChanged += new System.EventHandler(this.rdbThreeSec_CheckedChanged);
            // 
            // rdbOneSec
            // 
            this.rdbOneSec.AutoSize = true;
            this.rdbOneSec.Checked = true;
            this.rdbOneSec.Location = new System.Drawing.Point(40, 105);
            this.rdbOneSec.Name = "rdbOneSec";
            this.rdbOneSec.Size = new System.Drawing.Size(101, 16);
            this.rdbOneSec.TabIndex = 0;
            this.rdbOneSec.TabStop = true;
            this.rdbOneSec.Text = "每1秒切一张图";
            this.rdbOneSec.UseVisualStyleBackColor = true;
            this.rdbOneSec.CheckedChanged += new System.EventHandler(this.rdbOneSec_CheckedChanged);
            // 
            // rdbFiveSec
            // 
            this.rdbFiveSec.AutoSize = true;
            this.rdbFiveSec.Location = new System.Drawing.Point(40, 228);
            this.rdbFiveSec.Name = "rdbFiveSec";
            this.rdbFiveSec.Size = new System.Drawing.Size(101, 16);
            this.rdbFiveSec.TabIndex = 1;
            this.rdbFiveSec.Text = "每5秒切一张图";
            this.rdbFiveSec.UseVisualStyleBackColor = true;
            this.rdbFiveSec.CheckedChanged += new System.EventHandler(this.rdbFiveSec_CheckedChanged);
            // 
            // bgwVideo
            // 
            this.bgwVideo.WorkerReportsProgress = true;
            this.bgwVideo.WorkerSupportsCancellation = true;
            this.bgwVideo.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwVideo_DoWork);
            this.bgwVideo.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwVideo_ProgressChanged);
            this.bgwVideo.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwVideo_RunWorkerCompleted);
            // 
            // bgwFileLoading
            // 
            this.bgwFileLoading.WorkerReportsProgress = true;
            this.bgwFileLoading.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwFileLoading_DoWork);
            this.bgwFileLoading.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwFileLoading_ProgressChanged);
            this.bgwFileLoading.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwFileLoading_RunWorkerCompleted);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 552);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmMain";
            this.Text = "图片抽取工具 by GIAI";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.gbLog.ResumeLayout(false);
            this.gbLog.PerformLayout();
            this.gbSave.ResumeLayout(false);
            this.gbMethod.ResumeLayout(false);
            this.gbMethod.PerformLayout();
            this.gbFreq.ResumeLayout(false);
            this.gbFreq.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Button btnDir;
        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.GroupBox gbLog;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ListView lstFinished;
        private System.Windows.Forms.GroupBox gbSave;
        private System.Windows.Forms.RadioButton rdbEach;
        private System.Windows.Forms.RadioButton rdbAll;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox gbFreq;
        private System.Windows.Forms.RadioButton rdbThreeSec;
        private System.Windows.Forms.RadioButton rdbOneSec;
        private System.Windows.Forms.RadioButton rdbFiveSec;
        private System.Windows.Forms.GroupBox gbMethod;
        private System.Windows.Forms.RadioButton rdbdotfive;
        private System.Windows.Forms.Button btnCancel;
        private System.ComponentModel.BackgroundWorker bgwVideo;
        private System.ComponentModel.BackgroundWorker bgwFileLoading;
    }
}

