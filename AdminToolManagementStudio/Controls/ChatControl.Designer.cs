namespace AdminToolManagementStudio.Controls
{
    partial class ChatControl
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.stackPanel1 = new AdminToolManagementStudio.Controls.StackPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtNewMessage = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.btnSend = new Syncfusion.WinForms.Controls.SfButton();
            this.bannerTextProvider1 = new Syncfusion.Windows.Forms.BannerTextProvider(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNewMessage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.stackPanel1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(655, 466);
            this.panel1.TabIndex = 0;
            // 
            // stackPanel1
            // 
            this.stackPanel1.AutoScroll = true;
            this.stackPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stackPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.stackPanel1.Location = new System.Drawing.Point(0, 0);
            this.stackPanel1.Name = "stackPanel1";
            this.stackPanel1.Size = new System.Drawing.Size(655, 403);
            this.stackPanel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtNewMessage);
            this.panel2.Controls.Add(this.btnSend);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 403);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5);
            this.panel2.Size = new System.Drawing.Size(655, 63);
            this.panel2.TabIndex = 1;
            // 
            // txtNewMessage
            // 
            bannerTextInfo1.Mode = Syncfusion.Windows.Forms.BannerTextMode.EditMode;
            bannerTextInfo1.Text = "Type Message Here";
            bannerTextInfo1.Visible = true;
            this.bannerTextProvider1.SetBannerText(this.txtNewMessage, bannerTextInfo1);
            this.txtNewMessage.BeforeTouchSize = new System.Drawing.Size(552, 53);
            this.txtNewMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNewMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewMessage.Location = new System.Drawing.Point(5, 5);
            this.txtNewMessage.Multiline = true;
            this.txtNewMessage.Name = "txtNewMessage";
            this.txtNewMessage.Size = new System.Drawing.Size(552, 53);
            this.txtNewMessage.TabIndex = 5;
            this.txtNewMessage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNewMessage_KeyDown);
            // 
            // btnSend
            // 
            this.btnSend.AccessibleName = "Button";
            this.btnSend.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSend.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnSend.Location = new System.Drawing.Point(557, 5);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(93, 53);
            this.btnSend.Style.BackColor = System.Drawing.Color.Green;
            this.btnSend.Style.FocusedBackColor = System.Drawing.Color.Green;
            this.btnSend.Style.FocusedForeColor = System.Drawing.Color.White;
            this.btnSend.Style.ForeColor = System.Drawing.Color.White;
            this.btnSend.Style.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(0)))));
            this.btnSend.Style.HoverForeColor = System.Drawing.Color.White;
            this.btnSend.Style.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(163)))), ((int)(((byte)(85)))));
            this.btnSend.Style.PressedForeColor = System.Drawing.Color.White;
            this.btnSend.TabIndex = 4;
            this.btnSend.Text = "Send";
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // ChatControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Name = "ChatControl";
            this.Size = new System.Drawing.Size(655, 466);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNewMessage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Syncfusion.WinForms.Controls.SfButton btnSend;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtNewMessage;
        private Syncfusion.Windows.Forms.BannerTextProvider bannerTextProvider1;
        private StackPanel stackPanel1;
    }
}
