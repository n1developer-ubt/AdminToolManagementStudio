namespace ToolsMarket.Forms
{
    partial class Login
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
            Syncfusion.Windows.Forms.BannerTextInfo bannerTextInfo1 = new Syncfusion.Windows.Forms.BannerTextInfo();
            Syncfusion.Windows.Forms.BannerTextInfo bannerTextInfo2 = new Syncfusion.Windows.Forms.BannerTextInfo();
            this.txtUsername = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassword = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.btnLogin = new Syncfusion.WinForms.Controls.SfButton();
            this.chkRememberMe = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.bannerTextProvider1 = new Syncfusion.Windows.Forms.BannerTextProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkRememberMe)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            bannerTextInfo1.Mode = Syncfusion.Windows.Forms.BannerTextMode.EditMode;
            bannerTextInfo1.Text = "Username";
            bannerTextInfo1.Visible = true;
            this.bannerTextProvider1.SetBannerText(this.txtUsername, bannerTextInfo1);
            this.txtUsername.BeforeTouchSize = new System.Drawing.Size(240, 26);
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(5, 70);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(240, 26);
            this.txtUsername.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login To Continue";
            // 
            // txtPassword
            // 
            bannerTextInfo2.Mode = Syncfusion.Windows.Forms.BannerTextMode.EditMode;
            bannerTextInfo2.Text = "Password";
            bannerTextInfo2.Visible = true;
            this.bannerTextProvider1.SetBannerText(this.txtPassword, bannerTextInfo2);
            this.txtPassword.BeforeTouchSize = new System.Drawing.Size(240, 26);
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(5, 123);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(240, 26);
            this.txtPassword.TabIndex = 0;
            // 
            // btnLogin
            // 
            this.btnLogin.AccessibleName = "Button";
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnLogin.Location = new System.Drawing.Point(77, 231);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(96, 28);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // chkRememberMe
            // 
            this.chkRememberMe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.chkRememberMe.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.chkRememberMe.Checked = true;
            this.chkRememberMe.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRememberMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRememberMe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.chkRememberMe.HotBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.chkRememberMe.Location = new System.Drawing.Point(5, 175);
            this.chkRememberMe.Name = "chkRememberMe";
            this.chkRememberMe.Size = new System.Drawing.Size(150, 21);
            this.chkRememberMe.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016Colorful;
            this.chkRememberMe.TabIndex = 3;
            this.chkRememberMe.Text = "Remember me";
            this.chkRememberMe.ThemeName = "Office2016Colorful";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 311);
            this.Controls.Add(this.chkRememberMe);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkRememberMe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtUsername;
        private System.Windows.Forms.Label label1;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtPassword;
        private Syncfusion.WinForms.Controls.SfButton btnLogin;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv chkRememberMe;
        private Syncfusion.Windows.Forms.BannerTextProvider bannerTextProvider1;
    }
}