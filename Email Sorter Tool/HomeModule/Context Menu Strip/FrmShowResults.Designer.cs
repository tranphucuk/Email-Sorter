namespace Email_Sorter_Tool.HomeModule.Context_Menu_Strip
{
    partial class FrmShowResults
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmShowResults));
            this.lblTotalEmails = new DevExpress.XtraEditors.LabelControl();
            this.lblEmailType = new DevExpress.XtraEditors.LabelControl();
            this.mmEmailResults = new DevExpress.XtraEditors.MemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.mmEmailResults.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTotalEmails
            // 
            this.lblTotalEmails.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalEmails.Appearance.Options.UseFont = true;
            this.lblTotalEmails.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblTotalEmails.Location = new System.Drawing.Point(6, 52);
            this.lblTotalEmails.Name = "lblTotalEmails";
            this.lblTotalEmails.Size = new System.Drawing.Size(167, 16);
            this.lblTotalEmails.TabIndex = 4;
            this.lblTotalEmails.Text = "Total: 0";
            // 
            // lblEmailType
            // 
            this.lblEmailType.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailType.Appearance.Options.UseFont = true;
            this.lblEmailType.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblEmailType.Location = new System.Drawing.Point(6, 16);
            this.lblEmailType.Name = "lblEmailType";
            this.lblEmailType.Size = new System.Drawing.Size(474, 30);
            this.lblEmailType.TabIndex = 3;
            this.lblEmailType.Text = "GMail Results";
            // 
            // mmEmailResults
            // 
            this.mmEmailResults.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mmEmailResults.Location = new System.Drawing.Point(0, 74);
            this.mmEmailResults.Name = "mmEmailResults";
            this.mmEmailResults.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.mmEmailResults.Properties.Appearance.Options.UseBackColor = true;
            this.mmEmailResults.Properties.ReadOnly = true;
            this.mmEmailResults.Size = new System.Drawing.Size(340, 224);
            this.mmEmailResults.TabIndex = 2;
            // 
            // FrmShowResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 298);
            this.Controls.Add(this.lblTotalEmails);
            this.Controls.Add(this.lblEmailType);
            this.Controls.Add(this.mmEmailResults);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmShowResults";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GridView Results";
            ((System.ComponentModel.ISupportInitialize)(this.mmEmailResults.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblTotalEmails;
        private DevExpress.XtraEditors.LabelControl lblEmailType;
        private DevExpress.XtraEditors.MemoEdit mmEmailResults;
    }
}