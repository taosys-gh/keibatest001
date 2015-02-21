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
            ((System.ComponentModel.ISupportInitialize)(this.axJVLink)).BeginInit();
            this.SuspendLayout();
            // 
            // axJVLink
            // 
            this.axJVLink.Enabled = true;
            this.axJVLink.Location = new System.Drawing.Point(156, 127);
            this.axJVLink.Name = "axJVLink";
            this.axJVLink.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axJVLink.OcxState")));
            this.axJVLink.Size = new System.Drawing.Size(240, 240);
            this.axJVLink.TabIndex = 0;
            // 
            // cmdJVLinkDialog
            // 
            this.cmdJVLinkDialog.Location = new System.Drawing.Point(181, 69);
            this.cmdJVLinkDialog.Name = "cmdJVLinkDialog";
            this.cmdJVLinkDialog.Size = new System.Drawing.Size(75, 23);
            this.cmdJVLinkDialog.TabIndex = 2;
            this.cmdJVLinkDialog.Text = "JV読込";
            this.cmdJVLinkDialog.UseVisualStyleBackColor = true;
            this.cmdJVLinkDialog.Click += new System.EventHandler(this.cmdJVLinkDialog_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.cmdJVLinkDialog);
            this.Controls.Add(this.axJVLink);
            this.Name = "frmMain";
            this.Text = "メイン画面";
            ((System.ComponentModel.ISupportInitialize)(this.axJVLink)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public AxJVDTLabLib.AxJVLink axJVLink;
        private System.Windows.Forms.Button cmdJVLinkDialog;
    }
}

