namespace AdminToolManagementStudio.Forms
{
    partial class Tool
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
            Syncfusion.Windows.Forms.BannerTextInfo bannerTextInfo3 = new Syncfusion.Windows.Forms.BannerTextInfo();
            Syncfusion.Windows.Forms.BannerTextInfo bannerTextInfo4 = new Syncfusion.Windows.Forms.BannerTextInfo();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tool));
            this.bannerTextProvider1 = new Syncfusion.Windows.Forms.BannerTextProvider(this.components);
            this.txtSmtp = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.txtUsername = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.txtPassword = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.txtProductType = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.btnAction = new Syncfusion.WinForms.Controls.SfButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtPort = new Syncfusion.WinForms.Input.SfNumericTextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.chkSSL = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.txtPrice = new Syncfusion.WinForms.Input.SfNumericTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtSmtp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSSL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSmtp
            // 
            bannerTextInfo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            bannerTextInfo1.Text = "Host";
            bannerTextInfo1.Visible = true;
            this.bannerTextProvider1.SetBannerText(this.txtSmtp, bannerTextInfo1);
            this.txtSmtp.BeforeTouchSize = new System.Drawing.Size(655, 26);
            this.txtSmtp.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtSmtp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSmtp.Location = new System.Drawing.Point(2, 2);
            this.txtSmtp.Margin = new System.Windows.Forms.Padding(10);
            this.txtSmtp.Name = "txtSmtp";
            this.txtSmtp.Size = new System.Drawing.Size(324, 26);
            this.txtSmtp.TabIndex = 8;
            // 
            // txtUsername
            // 
            bannerTextInfo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            bannerTextInfo2.Text = "Username";
            bannerTextInfo2.Visible = true;
            this.bannerTextProvider1.SetBannerText(this.txtUsername, bannerTextInfo2);
            this.txtUsername.BeforeTouchSize = new System.Drawing.Size(655, 26);
            this.txtUsername.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(2, 74);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(10);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(324, 26);
            this.txtUsername.TabIndex = 16;
            // 
            // txtPassword
            // 
            bannerTextInfo3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            bannerTextInfo3.Text = "Password";
            bannerTextInfo3.Visible = true;
            this.bannerTextProvider1.SetBannerText(this.txtPassword, bannerTextInfo3);
            this.txtPassword.BeforeTouchSize = new System.Drawing.Size(655, 26);
            this.txtPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(2, 110);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(10);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(324, 26);
            this.txtPassword.TabIndex = 18;
            // 
            // txtProductType
            // 
            bannerTextInfo4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            bannerTextInfo4.Text = "Product Type";
            bannerTextInfo4.Visible = true;
            this.bannerTextProvider1.SetBannerText(this.txtProductType, bannerTextInfo4);
            this.txtProductType.BeforeTouchSize = new System.Drawing.Size(655, 26);
            this.txtProductType.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtProductType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductType.Location = new System.Drawing.Point(2, 213);
            this.txtProductType.Margin = new System.Windows.Forms.Padding(10);
            this.txtProductType.Name = "txtProductType";
            this.txtProductType.Size = new System.Drawing.Size(324, 26);
            this.txtProductType.TabIndex = 23;
            // 
            // btnAction
            // 
            this.btnAction.AccessibleName = "Button";
            this.btnAction.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAction.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnAction.Location = new System.Drawing.Point(2, 325);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(324, 31);
            this.btnAction.Style.BackColor = System.Drawing.Color.Green;
            this.btnAction.Style.FocusedBackColor = System.Drawing.Color.Green;
            this.btnAction.Style.FocusedForeColor = System.Drawing.Color.White;
            this.btnAction.Style.ForeColor = System.Drawing.Color.White;
            this.btnAction.Style.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(0)))));
            this.btnAction.Style.HoverForeColor = System.Drawing.Color.White;
            this.btnAction.Style.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(163)))), ((int)(((byte)(85)))));
            this.btnAction.Style.PressedForeColor = System.Drawing.Color.White;
            this.btnAction.TabIndex = 13;
            this.btnAction.Text = "Add New Tool";
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(2, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(324, 10);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // txtPort
            // 
            this.txtPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPort.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPort.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtPort.HideTrailingZeros = true;
            this.txtPort.Location = new System.Drawing.Point(2, 38);
            this.txtPort.MinValue = 1D;
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(324, 26);
            this.txtPort.Style.NegativeForeColor = System.Drawing.Color.Red;
            this.txtPort.TabIndex = 14;
            this.txtPort.Text = "587";
            this.txtPort.Value = 587D;
            this.txtPort.WatermarkText = "Port";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox2.Location = new System.Drawing.Point(2, 64);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(324, 10);
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox3.Location = new System.Drawing.Point(2, 100);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(324, 10);
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox4.Location = new System.Drawing.Point(2, 136);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(324, 10);
            this.pictureBox4.TabIndex = 19;
            this.pictureBox4.TabStop = false;
            // 
            // chkSSL
            // 
            this.chkSSL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.chkSSL.BeforeTouchSize = new System.Drawing.Size(324, 31);
            this.chkSSL.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.chkSSL.Dock = System.Windows.Forms.DockStyle.Top;
            this.chkSSL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.chkSSL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.chkSSL.HotBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.chkSSL.Location = new System.Drawing.Point(2, 146);
            this.chkSSL.Name = "chkSSL";
            this.chkSSL.Size = new System.Drawing.Size(324, 31);
            this.chkSSL.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2016Colorful;
            this.chkSSL.TabIndex = 20;
            this.chkSSL.Text = "SSL";
            this.chkSSL.ThemeName = "Office2016Colorful";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox5.Location = new System.Drawing.Point(2, 203);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(324, 10);
            this.pictureBox5.TabIndex = 22;
            this.pictureBox5.TabStop = false;
            // 
            // txtPrice
            // 
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrice.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPrice.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtPrice.HideTrailingZeros = true;
            this.txtPrice.Location = new System.Drawing.Point(2, 177);
            this.txtPrice.MinValue = 0D;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(324, 26);
            this.txtPrice.Style.NegativeForeColor = System.Drawing.Color.Red;
            this.txtPrice.TabIndex = 21;
            this.txtPrice.Text = "1";
            this.txtPrice.Value = 1D;
            this.txtPrice.WatermarkText = "Port";
            // 
            // Tool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 358);
            this.Controls.Add(this.txtProductType);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.chkSSL);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.btnAction);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtSmtp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Tool";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add New Tool";
            ((System.ComponentModel.ISupportInitialize)(this.txtSmtp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSSL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.Windows.Forms.BannerTextProvider bannerTextProvider1;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtSmtp;
        private Syncfusion.WinForms.Controls.SfButton btnAction;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Syncfusion.WinForms.Input.SfNumericTextBox txtPort;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtUsername;
        private System.Windows.Forms.PictureBox pictureBox4;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtPassword;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv chkSSL;
        private System.Windows.Forms.PictureBox pictureBox5;
        private Syncfusion.WinForms.Input.SfNumericTextBox txtPrice;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtProductType;
    }
}