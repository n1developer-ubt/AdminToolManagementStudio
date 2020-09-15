namespace ToolsMarket.Controls
{
    partial class OtherOrders
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
            Syncfusion.WinForms.DataGrid.GridNumericColumn gridNumericColumn4 = new Syncfusion.WinForms.DataGrid.GridNumericColumn();
            Syncfusion.WinForms.DataGrid.GridNumericColumn gridNumericColumn5 = new Syncfusion.WinForms.DataGrid.GridNumericColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn5 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn6 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn7 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn8 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridNumericColumn gridNumericColumn6 = new Syncfusion.WinForms.DataGrid.GridNumericColumn();
            Syncfusion.WinForms.DataGrid.GridButtonColumn gridButtonColumn2 = new Syncfusion.WinForms.DataGrid.GridButtonColumn();
            Syncfusion.Windows.Forms.BannerTextInfo bannerTextInfo2 = new Syncfusion.Windows.Forms.BannerTextInfo();
            this.sfDataGrid1 = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReload = new Syncfusion.WinForms.Controls.SfButton();
            this.txtSearch = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bannerTextProvider1 = new Syncfusion.Windows.Forms.BannerTextProvider(this.components);
            this.sfButton1 = new Syncfusion.WinForms.Controls.SfButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGrid1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // sfDataGrid1
            // 
            this.sfDataGrid1.AccessibleName = "Table";
            this.sfDataGrid1.AllowEditing = false;
            this.sfDataGrid1.AutoGenerateColumns = false;
            this.sfDataGrid1.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            gridNumericColumn4.AllowEditing = false;
            gridNumericColumn4.Format = "{0}";
            gridNumericColumn4.HeaderText = "Order Id";
            gridNumericColumn4.MappingName = "Id";
            gridNumericColumn4.MaximumWidth = 70D;
            gridNumericColumn5.AllowEditing = false;
            gridNumericColumn5.Format = "{0}";
            gridNumericColumn5.HeaderText = "Tool Id";
            gridNumericColumn5.MappingName = "Tool.Id";
            gridNumericColumn5.MaximumWidth = 70D;
            gridTextColumn5.AllowEditing = false;
            gridTextColumn5.Format = "{0}";
            gridTextColumn5.HeaderText = "Smtp";
            gridTextColumn5.MappingName = "Tool.Smtp";
            gridTextColumn6.AllowEditing = false;
            gridTextColumn6.HeaderText = "Username";
            gridTextColumn6.MappingName = "Tool.Username";
            gridTextColumn7.AllowEditing = false;
            gridTextColumn7.HeaderText = "Description";
            gridTextColumn7.MappingName = "Tool.Description";
            gridTextColumn8.AllowEditing = false;
            gridTextColumn8.HeaderText = "Password";
            gridTextColumn8.MappingName = "Tool.Password";
            gridNumericColumn6.AllowEditing = false;
            gridNumericColumn6.Format = "{0}";
            gridNumericColumn6.HeaderText = "Price";
            gridNumericColumn6.MappingName = "Tool.Price";
            gridButtonColumn2.AllowDefaultButtonText = false;
            gridButtonColumn2.AllowEditing = false;
            gridButtonColumn2.ButtonSize = new System.Drawing.Size(0, 0);
            gridButtonColumn2.DefaultButtonText = "";
            gridButtonColumn2.HeaderText = "Action";
            gridButtonColumn2.ImageSize = new System.Drawing.Size(0, 0);
            gridButtonColumn2.MappingName = "Column8";
            gridButtonColumn2.NullDisplayText = "Copy";
            this.sfDataGrid1.Columns.Add(gridNumericColumn4);
            this.sfDataGrid1.Columns.Add(gridNumericColumn5);
            this.sfDataGrid1.Columns.Add(gridTextColumn5);
            this.sfDataGrid1.Columns.Add(gridTextColumn6);
            this.sfDataGrid1.Columns.Add(gridTextColumn7);
            this.sfDataGrid1.Columns.Add(gridTextColumn8);
            this.sfDataGrid1.Columns.Add(gridNumericColumn6);
            this.sfDataGrid1.Columns.Add(gridButtonColumn2);
            this.sfDataGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sfDataGrid1.Location = new System.Drawing.Point(0, 0);
            this.sfDataGrid1.Name = "sfDataGrid1";
            this.sfDataGrid1.Size = new System.Drawing.Size(765, 470);
            this.sfDataGrid1.TabIndex = 0;
            this.sfDataGrid1.Text = "sfDataGrid1";
            this.sfDataGrid1.CellButtonClick += new Syncfusion.WinForms.DataGrid.Events.CellButtonClickEventHandler(this.sfDataGrid1_CellButtonClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.sfButton1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnReload);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(765, 40);
            this.panel1.TabIndex = 3;
            // 
            // btnReload
            // 
            this.btnReload.AccessibleName = "Button";
            this.btnReload.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnReload.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnReload.Location = new System.Drawing.Point(670, 5);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(90, 30);
            this.btnReload.Style.BackColor = System.Drawing.Color.Green;
            this.btnReload.Style.FocusedBackColor = System.Drawing.Color.Green;
            this.btnReload.Style.FocusedForeColor = System.Drawing.Color.White;
            this.btnReload.Style.ForeColor = System.Drawing.Color.White;
            this.btnReload.Style.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(0)))));
            this.btnReload.Style.HoverForeColor = System.Drawing.Color.White;
            this.btnReload.Style.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(163)))), ((int)(((byte)(85)))));
            this.btnReload.Style.PressedForeColor = System.Drawing.Color.White;
            this.btnReload.TabIndex = 3;
            this.btnReload.Text = "Reload";
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // txtSearch
            // 
            bannerTextInfo2.Mode = Syncfusion.Windows.Forms.BannerTextMode.EditMode;
            bannerTextInfo2.Text = "Search Everywhere";
            bannerTextInfo2.Visible = true;
            this.bannerTextProvider1.SetBannerText(this.txtSearch, bannerTextInfo2);
            this.txtSearch.BeforeTouchSize = new System.Drawing.Size(279, 29);
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(5, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(279, 29);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.sfDataGrid1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(765, 470);
            this.panel2.TabIndex = 4;
            // 
            // sfButton1
            // 
            this.sfButton1.AccessibleName = "Button";
            this.sfButton1.Dock = System.Windows.Forms.DockStyle.Right;
            this.sfButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.sfButton1.Location = new System.Drawing.Point(570, 5);
            this.sfButton1.Name = "sfButton1";
            this.sfButton1.Size = new System.Drawing.Size(90, 30);
            this.sfButton1.Style.BackColor = System.Drawing.Color.Green;
            this.sfButton1.Style.FocusedBackColor = System.Drawing.Color.Green;
            this.sfButton1.Style.FocusedForeColor = System.Drawing.Color.White;
            this.sfButton1.Style.ForeColor = System.Drawing.Color.White;
            this.sfButton1.Style.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(0)))));
            this.sfButton1.Style.HoverForeColor = System.Drawing.Color.White;
            this.sfButton1.Style.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(163)))), ((int)(((byte)(85)))));
            this.sfButton1.Style.PressedForeColor = System.Drawing.Color.White;
            this.sfButton1.TabIndex = 7;
            this.sfButton1.Text = "Copy All";
            this.sfButton1.Click += new System.EventHandler(this.sfButton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Location = new System.Drawing.Point(660, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(10, 30);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // OtherOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "OtherOrders";
            this.Size = new System.Drawing.Size(765, 510);
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGrid1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.WinForms.DataGrid.SfDataGrid sfDataGrid1;
        private System.Windows.Forms.Panel panel1;
        private Syncfusion.WinForms.Controls.SfButton btnReload;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtSearch;
        private System.Windows.Forms.Panel panel2;
        private Syncfusion.Windows.Forms.BannerTextProvider bannerTextProvider1;
        private Syncfusion.WinForms.Controls.SfButton sfButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
