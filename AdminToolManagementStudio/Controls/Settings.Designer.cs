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
            Syncfusion.Windows.Forms.BannerTextInfo bannerTextInfo6 = new Syncfusion.Windows.Forms.BannerTextInfo();
            Syncfusion.Windows.Forms.BannerTextInfo bannerTextInfo5 = new Syncfusion.Windows.Forms.BannerTextInfo();
            Syncfusion.Windows.Forms.BannerTextInfo bannerTextInfo4 = new Syncfusion.Windows.Forms.BannerTextInfo();
            Syncfusion.Windows.Forms.BannerTextInfo bannerTextInfo3 = new Syncfusion.Windows.Forms.BannerTextInfo();
            Syncfusion.Windows.Forms.BannerTextInfo bannerTextInfo2 = new Syncfusion.Windows.Forms.BannerTextInfo();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTempEmail = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.btnSaveTempEmail = new System.Windows.Forms.Button();
            this.bannerTextProvider1 = new Syncfusion.Windows.Forms.BannerTextProvider(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.txtHost = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.txtPort = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.txtUsername = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.txtPassword = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.txtDatabaseName = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTempEmail)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDatabaseName)).BeginInit();
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
            // txtTempEmail
            // 
            bannerTextInfo1.Text = "Enter Temporary Email For Tool Testing";
            this.bannerTextProvider1.SetBannerText(this.txtTempEmail, bannerTextInfo1);
            this.txtTempEmail.BeforeTouchSize = new System.Drawing.Size(655, 26);
            this.txtTempEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTempEmail.Location = new System.Drawing.Point(5, 24);
            this.txtTempEmail.Name = "txtTempEmail";
            this.txtTempEmail.Size = new System.Drawing.Size(655, 26);
            this.txtTempEmail.TabIndex = 2;
            // 
            // btnSaveTempEmail
            // 
            this.btnSaveTempEmail.BackColor = System.Drawing.Color.Green;
            this.btnSaveTempEmail.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSaveTempEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveTempEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveTempEmail.ForeColor = System.Drawing.Color.White;
            this.btnSaveTempEmail.Location = new System.Drawing.Point(660, 24);
            this.btnSaveTempEmail.Name = "btnSaveTempEmail";
            this.btnSaveTempEmail.Size = new System.Drawing.Size(75, 26);
            this.btnSaveTempEmail.TabIndex = 1;
            this.btnSaveTempEmail.Text = "Save";
            this.btnSaveTempEmail.UseVisualStyleBackColor = false;
            this.btnSaveTempEmail.Click += new System.EventHandler(this.btnSaveTempEmail_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDatabaseName);
            this.groupBox2.Controls.Add(this.txtPassword);
            this.groupBox2.Controls.Add(this.txtUsername);
            this.groupBox2.Controls.Add(this.txtPort);
            this.groupBox2.Controls.Add(this.txtHost);
            this.groupBox2.Controls.Add(this.btnSaveSettings);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(5, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox2.Size = new System.Drawing.Size(740, 160);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Database Settings";
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.BackColor = System.Drawing.Color.Green;
            this.btnSaveSettings.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSaveSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveSettings.ForeColor = System.Drawing.Color.White;
            this.btnSaveSettings.Location = new System.Drawing.Point(660, 24);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(75, 131);
            this.btnSaveSettings.TabIndex = 1;
            this.btnSaveSettings.Text = "Save";
            this.btnSaveSettings.UseVisualStyleBackColor = false;
            this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);
            // 
            // txtHost
            // 
            bannerTextInfo6.Text = "Host";
            bannerTextInfo6.Visible = true;
            this.bannerTextProvider1.SetBannerText(this.txtHost, bannerTextInfo6);
            this.txtHost.BeforeTouchSize = new System.Drawing.Size(655, 26);
            this.txtHost.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtHost.Location = new System.Drawing.Point(5, 24);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(655, 26);
            this.txtHost.TabIndex = 3;
            // 
            // txtPort
            // 
            bannerTextInfo5.Text = "Port";
            bannerTextInfo5.Visible = true;
            this.bannerTextProvider1.SetBannerText(this.txtPort, bannerTextInfo5);
            this.txtPort.BeforeTouchSize = new System.Drawing.Size(655, 26);
            this.txtPort.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtPort.Location = new System.Drawing.Point(5, 50);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(655, 26);
            this.txtPort.TabIndex = 4;
            // 
            // txtUsername
            // 
            bannerTextInfo4.Text = "Username";
            bannerTextInfo4.Visible = true;
            this.bannerTextProvider1.SetBannerText(this.txtUsername, bannerTextInfo4);
            this.txtUsername.BeforeTouchSize = new System.Drawing.Size(655, 26);
            this.txtUsername.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtUsername.Location = new System.Drawing.Point(5, 76);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(655, 26);
            this.txtUsername.TabIndex = 5;
            // 
            // txtPassword
            // 
            bannerTextInfo3.Text = "Password";
            bannerTextInfo3.Visible = true;
            this.bannerTextProvider1.SetBannerText(this.txtPassword, bannerTextInfo3);
            this.txtPassword.BeforeTouchSize = new System.Drawing.Size(655, 26);
            this.txtPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtPassword.Location = new System.Drawing.Point(5, 102);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(655, 26);
            this.txtPassword.TabIndex = 6;
            // 
            // txtDatabaseName
            // 
            bannerTextInfo2.Text = "Database Name";
            bannerTextInfo2.Visible = true;
            this.bannerTextProvider1.SetBannerText(this.txtDatabaseName, bannerTextInfo2);
            this.txtDatabaseName.BeforeTouchSize = new System.Drawing.Size(655, 26);
            this.txtDatabaseName.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtDatabaseName.Location = new System.Drawing.Point(5, 128);
            this.txtDatabaseName.Name = "txtDatabaseName";
            this.txtDatabaseName.Size = new System.Drawing.Size(655, 26);
            this.txtDatabaseName.TabIndex = 7;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Settings";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(750, 522);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTempEmail)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDatabaseName)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtTempEmail;
        private System.Windows.Forms.Button btnSaveTempEmail;
        private Syncfusion.Windows.Forms.BannerTextProvider bannerTextProvider1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSaveSettings;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtHost;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtPassword;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtUsername;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtPort;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtDatabaseName;
    }
}
