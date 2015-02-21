namespace KeibaTest001
{
    partial class frmMain
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.axJVLink = new AxJVDTLabLib.AxJVLink();
            this.cmdJVLinkDialog = new System.Windows.Forms.Button();
            this.lblMesage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.axJVLink)).BeginInit();
            this.SuspendLayout();
            // 
            // axJVLink
            // 
            this.axJVLink.Enabled = true;
            this.axJVLink.Location = new System.Drawing.Point(156, 127);
            this.axJVLink.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.axJVLink.Name = "axJVLink";
            this.axJVLink.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axJVLink.OcxState")));
            this.axJVLink.Size = new System.Drawing.Size(240, 240);
            this.axJVLink.TabIndex = 0;
            // 
            // cmdJVLinkDialog
            // 
            this.cmdJVLinkDialog.Location = new System.Drawing.Point(136, 55);
            this.cmdJVLinkDialog.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmdJVLinkDialog.Name = "cmdJVLinkDialog";
            this.cmdJVLinkDialog.Size = new System.Drawing.Size(56, 18);
            this.cmdJVLinkDialog.TabIndex = 2;
            this.cmdJVLinkDialog.Text = "JV読込";
            this.cmdJVLinkDialog.UseVisualStyleBackColor = true;
            this.cmdJVLinkDialog.Click += new System.EventHandler(this.cmdJVLinkDialog_Click);
            // 
            // lblMesage
            // 
            this.lblMesage.AutoSize = true;
            this.lblMesage.Location = new System.Drawing.Point(13, 127);
            this.lblMesage.Name = "lblMesage";
            this.lblMesage.Size = new System.Drawing.Size(50, 12);
            this.lblMesage.TabIndex = 3;
            this.lblMesage.Text = "message";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 202);
            this.Controls.Add(this.lblMesage);
            this.Controls.Add(this.cmdJVLinkDialog);
            this.Controls.Add(this.axJVLink);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmMain";
            this.Text = "メイン画面";
            ((System.ComponentModel.ISupportInitialize)(this.axJVLink)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public AxJVDTLabLib.AxJVLink axJVLink;
        private System.Windows.Forms.Button cmdJVLinkDialog;
        private System.Windows.Forms.Label lblMesage;
    }
}

