namespace AdminToolManagementStudio.Forms
{
    partial class Customer
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
            Syncfusion.Windows.Forms.BannerTextInfo bannerTextInfo10 = new Syncfusion.Windows.Forms.BannerTextInfo();
            Syncfusion.Windows.Forms.BannerTextInfo bannerTextInfo11 = new Syncfusion.Windows.Forms.BannerTextInfo();
            Syncfusion.Windows.Forms.BannerTextInfo bannerTextInfo12 = new Syncfusion.Windows.Forms.BannerTextInfo();
            this.txtName = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.bannerTextProvider1 = new Syncfusion.Windows.Forms.BannerTextProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtEmail = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.txtPassword = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnAction = new Syncfusion.WinForms.Controls.SfButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            bannerTextInfo10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            bannerTextInfo10.Text = "Enter Name";
            bannerTextInfo10.Visible = true;
            this.bannerTextProvider1.SetBannerText(this.txtName, bannerTextInfo10);
            this.txtName.BeforeTouchSize = new System.Drawing.Size(307, 26);
            this.txtName.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(2, 2);
            this.txtName.Margin = new System.Windows.Forms.Padding(10);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(307, 26);
            this.txtName.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(2, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(307, 10);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // txtEmail
            // 
            bannerTextInfo11.Text = "Email";
            bannerTextInfo11.Visible = true;
            this.bannerTextProvider1.SetBannerText(this.txtEmail, bannerTextInfo11);
            this.txtEmail.BeforeTouchSize = new System.Drawing.Size(307, 26);
            this.txtEmail.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(2, 38);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(10);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(307, 26);
            this.txtEmail.TabIndex = 2;
            // 
            // txtPassword
            // 
            bannerTextInfo12.Text = "Password";
            bannerTextInfo12.Visible = true;
            this.bannerTextProvider1.SetBannerText(this.txtPassword, bannerTextInfo12);
            this.txtPassword.BeforeTouchSize = new System.Drawing.Size(307, 26);
            this.txtPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(2, 74);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(10);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(307, 26);
            this.txtPassword.TabIndex = 4;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox2.Location = new System.Drawing.Point(2, 64);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(307, 10);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // btnAction
            // 
            this.btnAction.AccessibleName = "Button";
            this.btnAction.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAction.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnAction.Location = new System.Drawing.Point(2, 136);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(307, 31);
            this.btnAction.Style.BackColor = System.Drawing.Color.Green;
            this.btnAction.Style.FocusedBackColor = System.Drawing.Color.Green;
            this.btnAction.Style.FocusedForeColor = System.Drawing.Color.White;
            this.btnAction.Style.ForeColor = System.Drawing.Color.White;
            this.btnAction.Style.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(0)))));
            this.btnAction.Style.HoverForeColor = System.Drawing.Color.White;
            this.btnAction.Style.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(163)))), ((int)(((byte)(85)))));
            this.btnAction.Style.PressedForeColor = System.Drawing.Color.White;
            this.btnAction.TabIndex = 7;
            this.btnAction.Text = "Add New Customer";
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 169);
            this.Controls.Add(this.btnAction);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtName);
            this.Name = "Customer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Customer";
            ((System.ComponentModel.ISupportInitialize)(this.txtName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtName;
        private Syncfusion.Windows.Forms.BannerTextProvider bannerTextProvider1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtEmail;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtPassword;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Syncfusion.WinForms.Controls.SfButton btnAction;
    }
}