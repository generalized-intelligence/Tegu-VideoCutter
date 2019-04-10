namespace VideoCutGUI
{
    partial class frmErr
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstErr = new System.Windows.Forms.ListView();
            this.lblMark = new System.Windows.Forms.Label();
            this.btnOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstErr
            // 
            this.lstErr.Location = new System.Drawing.Point(12, 59);
            this.lstErr.Name = "lstErr";
            this.lstErr.Size = new System.Drawing.Size(297, 219);
            this.lstErr.TabIndex = 0;
            this.lstErr.UseCompatibleStateImageBehavior = false;
            this.lstErr.View = System.Windows.Forms.View.List;
            // 
            // lblMark
            // 
            this.lblMark.AutoSize = true;
            this.lblMark.Location = new System.Drawing.Point(12, 29);
            this.lblMark.Name = "lblMark";
            this.lblMark.Size = new System.Drawing.Size(173, 12);
            this.lblMark.TabIndex = 1;
            this.lblMark.Text = "抽取未全部完成，下列文件出错";
            // 
            // btnOut
            // 
            this.btnOut.Location = new System.Drawing.Point(208, 24);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(89, 23);
            this.btnOut.TabIndex = 2;
            this.btnOut.Text = "导出错误列表";
            this.btnOut.UseVisualStyleBackColor = true;
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // frmErr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 290);
            this.Controls.Add(this.btnOut);
            this.Controls.Add(this.lblMark);
            this.Controls.Add(this.lstErr);
            this.Name = "frmErr";
            this.Text = "出错列表";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstErr;
        private System.Windows.Forms.Label lblMark;
        private System.Windows.Forms.Button btnOut;
    }
}