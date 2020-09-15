namespace AdminToolManagementStudio.Controls
{
    partial class OtherOrder
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
            Syncfusion.WinForms.DataGrid.GridNumericColumn gridNumericColumn1 = new Syncfusion.WinForms.DataGrid.GridNumericColumn();
            Syncfusion.WinForms.DataGrid.GridNumericColumn gridNumericColumn2 = new Syncfusion.WinForms.DataGrid.GridNumericColumn();
            Syncfusion.WinForms.DataGrid.GridNumericColumn gridNumericColumn3 = new Syncfusion.WinForms.DataGrid.GridNumericColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn1 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn2 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn3 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridButtonColumn gridButtonColumn1 = new Syncfusion.WinForms.DataGrid.GridButtonColumn();
            Syncfusion.WinForms.DataGrid.GridButtonColumn gridButtonColumn2 = new Syncfusion.WinForms.DataGrid.GridButtonColumn();
            Syncfusion.WinForms.DataGrid.GridButtonColumn gridButtonColumn3 = new Syncfusion.WinForms.DataGrid.GridButtonColumn();
            Syncfusion.WinForms.DataGrid.GridNumericColumn gridNumericColumn4 = new Syncfusion.WinForms.DataGrid.GridNumericColumn();
            Syncfusion.Windows.Forms.BannerTextInfo bannerTextInfo1 = new Syncfusion.Windows.Forms.BannerTextInfo();
            this.sdgOrders = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReload = new Syncfusion.WinForms.Controls.SfButton();
            this.txtSearch = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bannerTextProvider1 = new Syncfusion.Windows.Forms.BannerTextProvider(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.sdgOrders)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // sdgOrders
            // 
            this.sdgOrders.AccessibleName = "Table";
            this.sdgOrders.AllowEditing = false;
            this.sdgOrders.AllowFiltering = true;
            this.sdgOrders.AutoExpandGroups = true;
            this.sdgOrders.AutoGenerateColumns = false;
            this.sdgOrders.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            gridNumericColumn1.AllowEditing = false;
            gridNumericColumn1.AllowFiltering = true;
            gridNumericColumn1.Format = "{0}";
            gridNumericColumn1.HeaderText = "Order Id";
            gridNumericColumn1.MappingName = "Id";
            gridNumericColumn1.MaximumWidth = 70D;
            gridNumericColumn2.AllowEditing = false;
            gridNumericColumn2.AllowFiltering = true;
            gridNumericColumn2.Format = "{0}";
            gridNumericColumn2.HeaderText = "Tool Id";
            gridNumericColumn2.MappingName = "Tool.Id";
            gridNumericColumn2.MaximumWidth = 70D;
            gridNumericColumn3.AllowEditing = false;
            gridNumericColumn3.AllowFiltering = true;
            gridNumericColumn3.Format = "{0}";
            gridNumericColumn3.HeaderText = "Customer Id";
            gridNumericColumn3.MappingName = "Customer.Id";
            gridNumericColumn3.MaximumWidth = 70D;
            gridTextColumn1.AllowEditing = false;
            gridTextColumn1.AllowFiltering = true;
            gridTextColumn1.HeaderText = "Smtp";
            gridTextColumn1.MappingName = "Tool.Smtp";
            gridTextColumn2.AllowEditing = false;
            gridTextColumn2.AllowFiltering = true;
            gridTextColumn2.HeaderText = "Description";
            gridTextColumn2.MappingName = "Tool.Description";
            gridTextColumn3.AllowEditing = false;
            gridTextColumn3.AllowFiltering = true;
            gridTextColumn3.HeaderText = "BuyingStatus";
            gridTextColumn3.MappingName = "Status";
            gridButtonColumn1.AllowDefaultButtonText = false;
            gridButtonColumn1.AllowEditing = false;
            gridButtonColumn1.AllowFiltering = true;
            gridButtonColumn1.ButtonSize = new System.Drawing.Size(0, 0);
            gridButtonColumn1.DefaultButtonText = "";
            gridButtonColumn1.HeaderText = "Accept";
            gridButtonColumn1.ImageSize = new System.Drawing.Size(0, 0);
            gridButtonColumn1.MappingName = "Accept";
            gridButtonColumn1.NullDisplayText = "Accept";
            gridButtonColumn2.AllowDefaultButtonText = false;
            gridButtonColumn2.AllowEditing = false;
            gridButtonColumn2.AllowFiltering = true;
            gridButtonColumn2.ButtonSize = new System.Drawing.Size(0, 0);
            gridButtonColumn2.DefaultButtonText = "";
            gridButtonColumn2.HeaderText = "Reject";
            gridButtonColumn2.ImageSize = new System.Drawing.Size(0, 0);
            gridButtonColumn2.MappingName = "Column8";
            gridButtonColumn2.NullDisplayText = "Reject";
            gridButtonColumn3.AllowDefaultButtonText = false;
            gridButtonColumn3.AllowEditing = false;
            gridButtonColumn3.AllowFiltering = true;
            gridButtonColumn3.ButtonSize = new System.Drawing.Size(0, 0);
            gridButtonColumn3.DefaultButtonText = "";
            gridButtonColumn3.HeaderText = "Delete";
            gridButtonColumn3.ImageSize = new System.Drawing.Size(0, 0);
            gridButtonColumn3.MappingName = "Column9";
            gridButtonColumn3.NullDisplayText = "Delete";
            gridNumericColumn4.AllowEditing = false;
            gridNumericColumn4.AllowFiltering = true;
            gridNumericColumn4.Format = "{0}";
            gridNumericColumn4.HeaderText = "Price";
            gridNumericColumn4.MappingName = "Tool.Price";
            this.sdgOrders.Columns.Add(gridNumericColumn1);
            this.sdgOrders.Columns.Add(gridNumericColumn2);
            this.sdgOrders.Columns.Add(gridNumericColumn3);
            this.sdgOrders.Columns.Add(gridTextColumn1);
            this.sdgOrders.Columns.Add(gridTextColumn2);
            this.sdgOrders.Columns.Add(gridTextColumn3);
            this.sdgOrders.Columns.Add(gridButtonColumn1);
            this.sdgOrders.Columns.Add(gridButtonColumn2);
            this.sdgOrders.Columns.Add(gridButtonColumn3);
            this.sdgOrders.Columns.Add(gridNumericColumn4);
            this.sdgOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sdgOrders.Location = new System.Drawing.Point(0, 0);
            this.sdgOrders.Name = "sdgOrders";
            this.sdgOrders.Size = new System.Drawing.Size(765, 426);
            this.sdgOrders.TabIndex = 0;
            this.sdgOrders.Text = "sfDataGrid1";
            this.sdgOrders.CellButtonClick += new Syncfusion.WinForms.DataGrid.Events.CellButtonClickEventHandler(this.sfDataGrid1_CellButtonClick);
            // 
            // panel1
            // 
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
            bannerTextInfo1.Mode = Syncfusion.Windows.Forms.BannerTextMode.EditMode;
            bannerTextInfo1.Text = "Search Everywhere";
            bannerTextInfo1.Visible = true;
            this.bannerTextProvider1.SetBannerText(this.txtSearch, bannerTextInfo1);
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
            this.panel2.Controls.Add(this.sdgOrders);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(765, 426);
            this.panel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 466);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(765, 44);
            this.panel3.TabIndex = 5;
            // 
            // OtherOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "OtherOrder";
            this.Size = new System.Drawing.Size(765, 510);
            ((System.ComponentModel.ISupportInitialize)(this.sdgOrders)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.WinForms.DataGrid.SfDataGrid sdgOrders;
        private System.Windows.Forms.Panel panel1;
        private Syncfusion.WinForms.Controls.SfButton btnReload;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtSearch;
        private System.Windows.Forms.Panel panel2;
        private Syncfusion.Windows.Forms.BannerTextProvider bannerTextProvider1;
        private System.Windows.Forms.Panel panel3;
    }
}
