namespace KeibaTest001
{
    partial class frmJVLinkDialog
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
            this.components = new System.ComponentModel.Container();
            this.cmdStart = new System.Windows.Forms.Button();
            this.tmrJVStatus = new System.Windows.Forms.Timer(this.components);
            this.txtDataSpec = new System.Windows.Forms.TextBox();
            this.txtFromDate = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtNormal = new System.Windows.Forms.RadioButton();
            this.rbtIsthisweek = new System.Windows.Forms.RadioButton();
            this.rbtSetup = new System.Windows.Forms.RadioButton();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdStart
            // 
            this.cmdStart.Location = new System.Drawing.Point(461, 40);
            this.cmdStart.Name = "cmdStart";
            this.cmdStart.Size = new System.Drawing.Size(112, 44);
            this.cmdStart.TabIndex = 0;
            this.cmdStart.Text = "読込開始";
            this.cmdStart.UseVisualStyleBackColor = true;
            this.cmdStart.Click += new System.EventHandler(this.cmdStart_Click);
            // 
            // txtDataSpec
            // 
            this.txtDataSpec.Location = new System.Drawing.Point(120, 30);
            this.txtDataSpec.Name = "txtDataSpec";
            this.txtDataSpec.Size = new System.Drawing.Size(187, 22);
            this.txtDataSpec.TabIndex = 1;
            this.txtDataSpec.Text = "0B41";
            // 
            // txtFromDate
            // 
            this.txtFromDate.Location = new System.Drawing.Point(120, 75);
            this.txtFromDate.Name = "txtFromDate";
            this.txtFromDate.Size = new System.Drawing.Size(187, 22);
            this.txtFromDate.TabIndex = 1;
            this.txtFromDate.Text = "201502211005";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtSetup);
            this.groupBox1.Controls.Add(this.rbtIsthisweek);
            this.groupBox1.Controls.Add(this.rbtNormal);
            this.groupBox1.Location = new System.Drawing.Point(120, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 66);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "対象";
            // 
            // rbtNormal
            // 
            this.rbtNormal.AutoSize = true;
            this.rbtNormal.Location = new System.Drawing.Point(21, 28);
            this.rbtNormal.Name = "rbtNormal";
            this.rbtNormal.Size = new System.Drawing.Size(58, 19);
            this.rbtNormal.TabIndex = 0;
            this.rbtNormal.TabStop = true;
            this.rbtNormal.Text = "通常";
            this.rbtNormal.UseVisualStyleBackColor = true;
            // 
            // rbtIsthisweek
            // 
            this.rbtIsthisweek.AutoSize = true;
            this.rbtIsthisweek.Location = new System.Drawing.Point(111, 28);
            this.rbtIsthisweek.Name = "rbtIsthisweek";
            this.rbtIsthisweek.Size = new System.Drawing.Size(58, 19);
            this.rbtIsthisweek.TabIndex = 0;
            this.rbtIsthisweek.TabStop = true;
            this.rbtIsthisweek.Text = "今週";
            this.rbtIsthisweek.UseVisualStyleBackColor = true;
            // 
            // rbtSetup
            // 
            this.rbtSetup.AutoSize = true;
            this.rbtSetup.Location = new System.Drawing.Point(206, 28);
            this.rbtSetup.Name = "rbtSetup";
            this.rbtSetup.Size = new System.Drawing.Size(91, 19);
            this.rbtSetup.TabIndex = 0;
            this.rbtSetup.TabStop = true;
            this.rbtSetup.Text = "セットアップ";
            this.rbtSetup.UseVisualStyleBackColor = true;
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(45, 266);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(546, 185);
            this.txtLog.TabIndex = 3;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(45, 215);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(546, 23);
            this.progressBar1.TabIndex = 4;
            // 
            // frmJVLinkDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 471);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtFromDate);
            this.Controls.Add(this.txtDataSpec);
            this.Controls.Add(this.cmdStart);
            this.Name = "frmJVLinkDialog";
            this.Text = "JVLinkDialog";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Button cmdStart;
        private System.Windows.Forms.Timer tmrJVStatus;
        private System.Windows.Forms.TextBox txtDataSpec;
        private System.Windows.Forms.TextBox txtFromDate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtNormal;
        private System.Windows.Forms.RadioButton rbtIsthisweek;
        private System.Windows.Forms.RadioButton rbtSetup;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}