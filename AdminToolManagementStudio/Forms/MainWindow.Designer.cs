namespace AdminToolManagementStudio.Forms
{
    partial class MainWindow
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
            AdminToolManagementStudio.Models.Settings settings2 = new AdminToolManagementStudio.Models.Settings();
            AdminToolManagementStudio.Models.DatabaseInfo databaseInfo1 = new AdminToolManagementStudio.Models.DatabaseInfo();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.tabControlAdv1 = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            this.tabPageAdv1 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.users1 = new AdminToolManagementStudio.Controls.Users();
            this.tabPageAdv2 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.tools1 = new AdminToolManagementStudio.Controls.Tools();
            this.tabPageAdv3 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.order1 = new AdminToolManagementStudio.Controls.Order();
            this.tabPageAdv5 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.ticket = new AdminToolManagementStudio.Controls.AdminTicketControl();
            this.tabPageAdv4 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.settings1 = new AdminToolManagementStudio.Controls.Settings();
            this.tabPageAdv6 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.tabPageAdv7 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.otherTools1 = new AdminToolManagementStudio.Controls.OtherTools();
            this.otherOrder1 = new AdminToolManagementStudio.Controls.OtherOrder();
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv1)).BeginInit();
            this.tabControlAdv1.SuspendLayout();
            this.tabPageAdv1.SuspendLayout();
            this.tabPageAdv2.SuspendLayout();
            this.tabPageAdv3.SuspendLayout();
            this.tabPageAdv5.SuspendLayout();
            this.tabPageAdv4.SuspendLayout();
            this.tabPageAdv6.SuspendLayout();
            this.tabPageAdv7.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlAdv1
            // 
            this.tabControlAdv1.ActiveTabColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.tabControlAdv1.ActiveTabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tabControlAdv1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControlAdv1.BeforeTouchSize = new System.Drawing.Size(796, 446);
            this.tabControlAdv1.Controls.Add(this.tabPageAdv1);
            this.tabControlAdv1.Controls.Add(this.tabPageAdv2);
            this.tabControlAdv1.Controls.Add(this.tabPageAdv7);
            this.tabControlAdv1.Controls.Add(this.tabPageAdv3);
            this.tabControlAdv1.Controls.Add(this.tabPageAdv6);
            this.tabControlAdv1.Controls.Add(this.tabPageAdv5);
            this.tabControlAdv1.Controls.Add(this.tabPageAdv4);
            this.tabControlAdv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlAdv1.ImageAlignmentR = Syncfusion.Windows.Forms.Tools.RelativeImageAlignment.AboveText;
            this.tabControlAdv1.Location = new System.Drawing.Point(2, 2);
            this.tabControlAdv1.Name = "tabControlAdv1";
            this.tabControlAdv1.RotateTextWhenVertical = true;
            this.tabControlAdv1.Size = new System.Drawing.Size(796, 446);
            this.tabControlAdv1.TabIndex = 1;
            this.tabControlAdv1.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererOffice2016Colorful);
            this.tabControlAdv1.ThemeName = "TabRendererOffice2016Colorful";
            this.tabControlAdv1.ThemeStyle.PrimitiveButtonStyle.DisabledNextPageImage = null;
            this.tabControlAdv1.SelectedIndexChanged += new System.EventHandler(this.tabControlAdv1_SelectedIndexChanged);
            // 
            // tabPageAdv1
            // 
            this.tabPageAdv1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabPageAdv1.Controls.Add(this.users1);
            this.tabPageAdv1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.tabPageAdv1.Image = global::AdminToolManagementStudio.Properties.Resources.Collaborator_Male_48px;
            this.tabPageAdv1.ImageSize = new System.Drawing.Size(32, 32);
            this.tabPageAdv1.Location = new System.Drawing.Point(78, 1);
            this.tabPageAdv1.Name = "tabPageAdv1";
            this.tabPageAdv1.ShowCloseButton = true;
            this.tabPageAdv1.Size = new System.Drawing.Size(716, 443);
            this.tabPageAdv1.TabFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageAdv1.TabIndex = 1;
            this.tabPageAdv1.Text = "Users";
            this.tabPageAdv1.ThemesEnabled = false;
            // 
            // users1
            // 
            this.users1.BackColor = System.Drawing.Color.White;
            this.users1.DbContext = null;
            this.users1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.users1.Location = new System.Drawing.Point(0, 0);
            this.users1.Name = "users1";
            this.users1.Size = new System.Drawing.Size(716, 443);
            this.users1.TabIndex = 0;
            // 
            // tabPageAdv2
            // 
            this.tabPageAdv2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabPageAdv2.Controls.Add(this.tools1);
            this.tabPageAdv2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.tabPageAdv2.Image = global::AdminToolManagementStudio.Properties.Resources.tool;
            this.tabPageAdv2.ImageSize = new System.Drawing.Size(32, 32);
            this.tabPageAdv2.Location = new System.Drawing.Point(78, 1);
            this.tabPageAdv2.Name = "tabPageAdv2";
            this.tabPageAdv2.ShowCloseButton = true;
            this.tabPageAdv2.Size = new System.Drawing.Size(716, 443);
            this.tabPageAdv2.TabFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageAdv2.TabIndex = 2;
            this.tabPageAdv2.Text = "Tools";
            this.tabPageAdv2.ThemesEnabled = false;
            // 
            // tools1
            // 
            this.tools1.BackColor = System.Drawing.Color.White;
            this.tools1.DbContext = null;
            this.tools1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tools1.Location = new System.Drawing.Point(0, 0);
            this.tools1.Name = "tools1";
            this.tools1.Size = new System.Drawing.Size(716, 443);
            this.tools1.TabIndex = 0;
            this.tools1.TempMail = null;
            // 
            // tabPageAdv3
            // 
            this.tabPageAdv3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabPageAdv3.Controls.Add(this.order1);
            this.tabPageAdv3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.tabPageAdv3.Image = global::AdminToolManagementStudio.Properties.Resources.product;
            this.tabPageAdv3.ImageSize = new System.Drawing.Size(32, 32);
            this.tabPageAdv3.Location = new System.Drawing.Point(78, 1);
            this.tabPageAdv3.Name = "tabPageAdv3";
            this.tabPageAdv3.ShowCloseButton = true;
            this.tabPageAdv3.Size = new System.Drawing.Size(716, 443);
            this.tabPageAdv3.TabFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tabPageAdv3.TabIndex = 3;
            this.tabPageAdv3.Text = "Order";
            this.tabPageAdv3.ThemesEnabled = false;
            // 
            // order1
            // 
            this.order1.BackColor = System.Drawing.Color.White;
            this.order1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.order1.Location = new System.Drawing.Point(0, 0);
            this.order1.Name = "order1";
            this.order1.Size = new System.Drawing.Size(716, 443);
            this.order1.TabIndex = 0;
            // 
            // tabPageAdv5
            // 
            this.tabPageAdv5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabPageAdv5.Controls.Add(this.ticket);
            this.tabPageAdv5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.tabPageAdv5.Image = global::AdminToolManagementStudio.Properties.Resources.technical_support;
            this.tabPageAdv5.ImageSize = new System.Drawing.Size(32, 32);
            this.tabPageAdv5.Location = new System.Drawing.Point(78, 1);
            this.tabPageAdv5.Name = "tabPageAdv5";
            this.tabPageAdv5.ShowCloseButton = true;
            this.tabPageAdv5.Size = new System.Drawing.Size(716, 443);
            this.tabPageAdv5.TabFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageAdv5.TabIndex = 5;
            this.tabPageAdv5.Text = "Support";
            this.tabPageAdv5.ThemesEnabled = false;
            // 
            // ticket
            // 
            this.ticket.BackColor = System.Drawing.Color.White;
            this.ticket.DbContext = null;
            this.ticket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ticket.Location = new System.Drawing.Point(0, 0);
            this.ticket.Name = "ticket";
            this.ticket.Size = new System.Drawing.Size(716, 443);
            this.ticket.TabIndex = 0;
            // 
            // tabPageAdv4
            // 
            this.tabPageAdv4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabPageAdv4.Controls.Add(this.settings1);
            this.tabPageAdv4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.tabPageAdv4.Image = global::AdminToolManagementStudio.Properties.Resources.Settings;
            this.tabPageAdv4.ImageSize = new System.Drawing.Size(32, 32);
            this.tabPageAdv4.Location = new System.Drawing.Point(78, 1);
            this.tabPageAdv4.Name = "tabPageAdv4";
            this.tabPageAdv4.ShowCloseButton = true;
            this.tabPageAdv4.Size = new System.Drawing.Size(716, 443);
            this.tabPageAdv4.TabFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tabPageAdv4.TabIndex = 4;
            this.tabPageAdv4.Text = "Settings";
            this.tabPageAdv4.ThemesEnabled = false;
            // 
            // settings1
            // 
            this.settings1.BackColor = System.Drawing.Color.White;
            this.settings1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settings1.Location = new System.Drawing.Point(0, 0);
            this.settings1.Name = "settings1";
            this.settings1.Padding = new System.Windows.Forms.Padding(5);
            databaseInfo1.DatabaseName = "";
            databaseInfo1.Host = "";
            databaseInfo1.Password = "";
            databaseInfo1.Port = "";
            databaseInfo1.Username = "";
            settings2.DatabaseInfo = databaseInfo1;
            settings2.TempEmail = "";
            this.settings1.Setting = settings2;
            this.settings1.Size = new System.Drawing.Size(716, 443);
            this.settings1.TabIndex = 0;
            // 
            // tabPageAdv6
            // 
            this.tabPageAdv6.Controls.Add(this.otherOrder1);
            this.tabPageAdv6.Image = global::AdminToolManagementStudio.Properties.Resources.product;
            this.tabPageAdv6.ImageSize = new System.Drawing.Size(32, 32);
            this.tabPageAdv6.Location = new System.Drawing.Point(78, 1);
            this.tabPageAdv6.Name = "tabPageAdv6";
            this.tabPageAdv6.ShowCloseButton = true;
            this.tabPageAdv6.Size = new System.Drawing.Size(716, 443);
            this.tabPageAdv6.TabFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tabPageAdv6.TabIndex = 6;
            this.tabPageAdv6.Text = "OOrders";
            this.tabPageAdv6.ThemesEnabled = false;
            // 
            // tabPageAdv7
            // 
            this.tabPageAdv7.Controls.Add(this.otherTools1);
            this.tabPageAdv7.Image = global::AdminToolManagementStudio.Properties.Resources.tool;
            this.tabPageAdv7.ImageSize = new System.Drawing.Size(32, 32);
            this.tabPageAdv7.Location = new System.Drawing.Point(78, 1);
            this.tabPageAdv7.Name = "tabPageAdv7";
            this.tabPageAdv7.ShowCloseButton = true;
            this.tabPageAdv7.Size = new System.Drawing.Size(716, 443);
            this.tabPageAdv7.TabFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tabPageAdv7.TabIndex = 7;
            this.tabPageAdv7.Text = "OTools";
            this.tabPageAdv7.ThemesEnabled = false;
            // 
            // otherTools1
            // 
            this.otherTools1.BackColor = System.Drawing.Color.White;
            this.otherTools1.DbContext = null;
            this.otherTools1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.otherTools1.Location = new System.Drawing.Point(0, 0);
            this.otherTools1.Name = "otherTools1";
            this.otherTools1.Size = new System.Drawing.Size(716, 443);
            this.otherTools1.TabIndex = 0;
            // 
            // otherOrder1
            // 
            this.otherOrder1.BackColor = System.Drawing.Color.White;
            this.otherOrder1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.otherOrder1.Location = new System.Drawing.Point(0, 0);
            this.otherOrder1.Name = "otherOrder1";
            this.otherOrder1.Size = new System.Drawing.Size(716, 443);
            this.otherOrder1.TabIndex = 0;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlAdv1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.Text = "Admin Management";
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv1)).EndInit();
            this.tabControlAdv1.ResumeLayout(false);
            this.tabPageAdv1.ResumeLayout(false);
            this.tabPageAdv2.ResumeLayout(false);
            this.tabPageAdv3.ResumeLayout(false);
            this.tabPageAdv5.ResumeLayout(false);
            this.tabPageAdv4.ResumeLayout(false);
            this.tabPageAdv6.ResumeLayout(false);
            this.tabPageAdv7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Syncfusion.Windows.Forms.Tools.TabControlAdv tabControlAdv1;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPageAdv1;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPageAdv2;
        private Controls.Users users1;
        private Controls.Tools tools1;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPageAdv3;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPageAdv4;
        private Controls.Settings settings1;
        private Controls.Order order1;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPageAdv5;
        private Controls.AdminTicketControl ticket;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPageAdv6;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPageAdv7;
        private Controls.OtherTools otherTools1;
        private Controls.OtherOrder otherOrder1;
    }
}

