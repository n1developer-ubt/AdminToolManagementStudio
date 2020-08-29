namespace AdminToolManagementStudio.Controls
{
    partial class Settings
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Syncfusion.Windows.Forms.BannerTextInfo bannerTextInfo1 = new Syncfusion.Windows.Forms.BannerTextInfo();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bannerTextProvider1 = new Syncfusion.Windows.Forms.BannerTextProvider(this.components);
            this.btnSaveTempEmail = new System.Windows.Forms.Button();
            this.txtTempEmail = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTempEmail)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTempEmail);
            this.groupBox1.Controls.Add(this.btnSaveTempEmail);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(740, 55);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Temporary Email";
            // 
            // btnSaveTempEmail
            // 
            this.btnSaveTempEmail.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSaveTempEmail.Location = new System.Drawing.Point(660, 24);
            this.btnSaveTempEmail.Name = "btnSaveTempEmail";
            this.btnSaveTempEmail.Size = new System.Drawing.Size(75, 26);
            this.btnSaveTempEmail.TabIndex = 1;
            this.btnSaveTempEmail.Text = "Save";
            this.btnSaveTempEmail.UseVisualStyleBackColor = true;
            this.btnSaveTempEmail.Click += new System.EventHandler(this.btnSaveTempEmail_Click);
            // 
            // txtTempEmail
            // 
            bannerTextInfo1.Text = "Enter Temporary Email For Tool Testing";
            this.bannerTextProvider1.SetBannerText(this.txtTempEmail, bannerTextInfo1);
            this.txtTempEmail.BeforeTouchSize = new System.Drawing.Size(324, 26);
            this.txtTempEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTempEmail.Location = new System.Drawing.Point(5, 24);
            this.txtTempEmail.Name = "txtTempEmail";
            this.txtTempEmail.Size = new System.Drawing.Size(655, 26);
            this.txtTempEmail.TabIndex = 2;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox1);
            this.Name = "Settings";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(750, 522);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTempEmail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtTempEmail;
        private System.Windows.Forms.Button btnSaveTempEmail;
        private Syncfusion.Windows.Forms.BannerTextProvider bannerTextProvider1;
    }
}
