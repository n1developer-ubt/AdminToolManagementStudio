namespace ToolsMarket.Forms
{
    partial class AddSupportTicket
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
            Syncfusion.Windows.Forms.BannerTextInfo bannerTextInfo3 = new Syncfusion.Windows.Forms.BannerTextInfo();
            Syncfusion.Windows.Forms.BannerTextInfo bannerTextInfo4 = new Syncfusion.Windows.Forms.BannerTextInfo();
            this.btnGenerateNewTicket = new Syncfusion.WinForms.Controls.SfButton();
            this.txtSubject = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bannerTextProvider1 = new Syncfusion.Windows.Forms.BannerTextProvider(this.components);
            this.txtDescription = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerateNewTicket
            // 
            this.btnGenerateNewTicket.AccessibleName = "Button";
            this.btnGenerateNewTicket.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnGenerateNewTicket.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnGenerateNewTicket.Location = new System.Drawing.Point(2, 315);
            this.btnGenerateNewTicket.Name = "btnGenerateNewTicket";
            this.btnGenerateNewTicket.Size = new System.Drawing.Size(320, 30);
            this.btnGenerateNewTicket.Style.BackColor = System.Drawing.Color.Green;
            this.btnGenerateNewTicket.Style.FocusedBackColor = System.Drawing.Color.Green;
            this.btnGenerateNewTicket.Style.FocusedForeColor = System.Drawing.Color.White;
            this.btnGenerateNewTicket.Style.ForeColor = System.Drawing.Color.White;
            this.btnGenerateNewTicket.Style.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(0)))));
            this.btnGenerateNewTicket.Style.HoverForeColor = System.Drawing.Color.White;
            this.btnGenerateNewTicket.Style.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(163)))), ((int)(((byte)(85)))));
            this.btnGenerateNewTicket.Style.PressedForeColor = System.Drawing.Color.White;
            this.btnGenerateNewTicket.TabIndex = 4;
            this.btnGenerateNewTicket.Text = "Generate New Ticket";
            this.btnGenerateNewTicket.Click += new System.EventHandler(this.btnGenerateNewTicket_Click);
            // 
            // txtSubject
            // 
            bannerTextInfo3.Mode = Syncfusion.Windows.Forms.BannerTextMode.EditMode;
            bannerTextInfo3.Text = "Subject";
            bannerTextInfo3.Visible = true;
            this.bannerTextProvider1.SetBannerText(this.txtSubject, bannerTextInfo3);
            this.txtSubject.BeforeTouchSize = new System.Drawing.Size(320, 186);
            this.txtSubject.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubject.Location = new System.Drawing.Point(2, 2);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(320, 26);
            this.txtSubject.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(2, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 10);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // txtDescription
            // 
            bannerTextInfo4.Mode = Syncfusion.Windows.Forms.BannerTextMode.EditMode;
            bannerTextInfo4.Text = "Description";
            bannerTextInfo4.Visible = true;
            this.bannerTextProvider1.SetBannerText(this.txtDescription, bannerTextInfo4);
            this.txtDescription.BeforeTouchSize = new System.Drawing.Size(320, 186);
            this.txtDescription.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(2, 38);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(320, 186);
            this.txtDescription.TabIndex = 7;
            // 
            // AddSupportTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 347);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.btnGenerateNewTicket);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddSupportTicket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddSupportTicket";
            ((System.ComponentModel.ISupportInitialize)(this.txtSubject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.WinForms.Controls.SfButton btnGenerateNewTicket;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtSubject;
        private Syncfusion.Windows.Forms.BannerTextProvider bannerTextProvider1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtDescription;
    }
}