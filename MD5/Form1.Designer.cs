namespace Hash
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMD5 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCompareMD5 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSHA1 = new System.Windows.Forms.TextBox();
            this.txtCompareSHA1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnCompare = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "文件:";
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(53, 6);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.ReadOnly = true;
            this.txtFilePath.Size = new System.Drawing.Size(307, 21);
            this.txtFilePath.TabIndex = 1;
            this.txtFilePath.Text = "请把文件拖拽到程序界面里...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "MD5:";
            // 
            // txtMD5
            // 
            this.txtMD5.Location = new System.Drawing.Point(53, 34);
            this.txtMD5.Name = "txtMD5";
            this.txtMD5.ReadOnly = true;
            this.txtMD5.Size = new System.Drawing.Size(307, 21);
            this.txtMD5.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "比较:";
            // 
            // txtCompareMD5
            // 
            this.txtCompareMD5.Location = new System.Drawing.Point(53, 62);
            this.txtCompareMD5.Name = "txtCompareMD5";
            this.txtCompareMD5.Size = new System.Drawing.Size(307, 21);
            this.txtCompareMD5.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "SHA1:";
            // 
            // txtSHA1
            // 
            this.txtSHA1.Location = new System.Drawing.Point(53, 89);
            this.txtSHA1.Name = "txtSHA1";
            this.txtSHA1.ReadOnly = true;
            this.txtSHA1.Size = new System.Drawing.Size(307, 21);
            this.txtSHA1.TabIndex = 7;
            // 
            // txtCompareSHA1
            // 
            this.txtCompareSHA1.Location = new System.Drawing.Point(53, 117);
            this.txtCompareSHA1.Name = "txtCompareSHA1";
            this.txtCompareSHA1.Size = new System.Drawing.Size(307, 21);
            this.txtCompareSHA1.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "比较:";
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(204, 155);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(75, 23);
            this.btnHelp.TabIndex = 11;
            this.btnHelp.Text = "帮助";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnCompare
            // 
            this.btnCompare.Location = new System.Drawing.Point(285, 155);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(75, 23);
            this.btnCompare.TabIndex = 10;
            this.btnCompare.Text = "比较";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Enabled = false;
            this.label7.Location = new System.Drawing.Point(12, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 12);
            this.label7.TabIndex = 13;
            this.label7.Text = "joysky@outlook.com";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Enabled = false;
            this.label6.Location = new System.Drawing.Point(14, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 12);
            this.label6.TabIndex = 14;
            this.label6.Text = "By JoySky 2014/5/27";
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(372, 183);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnCompare);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCompareSHA1);
            this.Controls.Add(this.txtSHA1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCompareMD5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMD5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(388, 221);
            this.MinimumSize = new System.Drawing.Size(388, 221);
            this.Name = "Form1";
            this.Text = "文件哈希值计算工具";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMD5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCompareMD5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSHA1;
        private System.Windows.Forms.TextBox txtCompareSHA1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnCompare;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}

