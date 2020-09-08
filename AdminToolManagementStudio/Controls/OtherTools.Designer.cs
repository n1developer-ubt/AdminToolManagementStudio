namespace AdminToolManagementStudio.Controls
{
    partial class OtherTools
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
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn1 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn2 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn3 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridCheckBoxColumn gridCheckBoxColumn1 = new Syncfusion.WinForms.DataGrid.GridCheckBoxColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn4 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridNumericColumn gridNumericColumn2 = new Syncfusion.WinForms.DataGrid.GridNumericColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn5 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridButtonColumn gridButtonColumn1 = new Syncfusion.WinForms.DataGrid.GridButtonColumn();
            Syncfusion.WinForms.DataGrid.GridButtonColumn gridButtonColumn2 = new Syncfusion.WinForms.DataGrid.GridButtonColumn();
            Syncfusion.Windows.Forms.BannerTextInfo bannerTextInfo1 = new Syncfusion.Windows.Forms.BannerTextInfo();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.sdgTools = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.pnlControls1 = new System.Windows.Forms.Panel();
            this.btnSaveChanges = new Syncfusion.WinForms.Controls.SfButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAddNewTool = new Syncfusion.WinForms.Controls.SfButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnImportFile = new Syncfusion.WinForms.Controls.SfButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnUpdateStatus = new Syncfusion.WinForms.Controls.SfButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnReload = new Syncfusion.WinForms.Controls.SfButton();
            this.txtSearch = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.bannerTextProvider1 = new Syncfusion.Windows.Forms.BannerTextProvider(this.components);
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sdgTools)).BeginInit();
            this.pnlControls1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.pnlControls1);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(808, 420);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.sdgTools);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 40);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(808, 340);
            this.panel4.TabIndex = 4;
            // 
            // sdgTools
            // 
            this.sdgTools.AccessibleName = "Table";
            this.sdgTools.AllowDeleting = true;
            this.sdgTools.AllowResizingColumns = true;
            this.sdgTools.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            gridNumericColumn1.AllowResizing = true;
            gridNumericColumn1.Format = "{0}";
            gridNumericColumn1.HeaderStyle.FilterIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            gridNumericColumn1.HeaderText = "#";
            gridNumericColumn1.MappingName = "Id";
            gridNumericColumn1.MaximumWidth = 50D;
            gridTextColumn1.AllowResizing = true;
            gridTextColumn1.HeaderStyle.FilterIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            gridTextColumn1.HeaderText = "Host";
            gridTextColumn1.MappingName = "Smtp";
            gridTextColumn2.AllowResizing = true;
            gridTextColumn2.HeaderStyle.FilterIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            gridTextColumn2.HeaderText = "Username";
            gridTextColumn2.MappingName = "Username";
            gridTextColumn3.AllowResizing = true;
            gridTextColumn3.HeaderStyle.FilterIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            gridTextColumn3.HeaderText = "Password";
            gridTextColumn3.MappingName = "Password";
            gridCheckBoxColumn1.AllowResizing = true;
            gridCheckBoxColumn1.HeaderStyle.FilterIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            gridCheckBoxColumn1.HeaderText = "Description";
            gridCheckBoxColumn1.MappingName = "Description";
            gridTextColumn4.AllowResizing = true;
            gridTextColumn4.HeaderStyle.FilterIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            gridTextColumn4.HeaderText = "Status";
            gridTextColumn4.MappingName = "Status";
            gridNumericColumn2.AllowResizing = true;
            gridNumericColumn2.Format = "{0}";
            gridNumericColumn2.HeaderStyle.FilterIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            gridNumericColumn2.HeaderText = "Price";
            gridNumericColumn2.MappingName = "Price";
            gridTextColumn5.AllowResizing = true;
            gridTextColumn5.HeaderStyle.FilterIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            gridTextColumn5.HeaderText = "Product Type";
            gridTextColumn5.MappingName = "Type";
            gridButtonColumn1.AllowDefaultButtonText = false;
            gridButtonColumn1.AllowResizing = true;
            gridButtonColumn1.ButtonSize = new System.Drawing.Size(0, 0);
            gridButtonColumn1.DefaultButtonText = "";
            gridButtonColumn1.HeaderText = "Action";
            gridButtonColumn1.ImageSize = new System.Drawing.Size(0, 0);
            gridButtonColumn1.MappingName = "Column10";
            gridButtonColumn1.NullDisplayText = "Delete";
            gridButtonColumn2.AllowDefaultButtonText = false;
            gridButtonColumn2.AllowResizing = true;
            gridButtonColumn2.ButtonSize = new System.Drawing.Size(0, 0);
            gridButtonColumn2.DefaultButtonText = "";
            gridButtonColumn2.HeaderText = "Check Status";
            gridButtonColumn2.ImageSize = new System.Drawing.Size(0, 0);
            gridButtonColumn2.MappingName = "Column11";
            gridButtonColumn2.NullDisplayText = "Update Status";
            this.sdgTools.Columns.Add(gridNumericColumn1);
            this.sdgTools.Columns.Add(gridTextColumn1);
            this.sdgTools.Columns.Add(gridTextColumn2);
            this.sdgTools.Columns.Add(gridTextColumn3);
            this.sdgTools.Columns.Add(gridCheckBoxColumn1);
            this.sdgTools.Columns.Add(gridTextColumn4);
            this.sdgTools.Columns.Add(gridNumericColumn2);
            this.sdgTools.Columns.Add(gridTextColumn5);
            this.sdgTools.Columns.Add(gridButtonColumn1);
            this.sdgTools.Columns.Add(gridButtonColumn2);
            this.sdgTools.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sdgTools.Location = new System.Drawing.Point(0, 0);
            this.sdgTools.Name = "sdgTools";
            this.sdgTools.Size = new System.Drawing.Size(808, 340);
            this.sdgTools.Style.HeaderStyle.FilterIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.sdgTools.TabIndex = 0;
            this.sdgTools.Text = "sfDataGrid1";
            this.sdgTools.QueryRowStyle += new Syncfusion.WinForms.DataGrid.Events.QueryRowStyleEventHandler(this.sdgTools_QueryRowStyle);
            this.sdgTools.CellButtonClick += new Syncfusion.WinForms.DataGrid.Events.CellButtonClickEventHandler(this.sdgTools_CellButtonClick);
            // 
            // pnlControls1
            // 
            this.pnlControls1.Controls.Add(this.btnSaveChanges);
            this.pnlControls1.Controls.Add(this.pictureBox1);
            this.pnlControls1.Controls.Add(this.btnAddNewTool);
            this.pnlControls1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlControls1.Location = new System.Drawing.Point(0, 380);
            this.pnlControls1.Name = "pnlControls1";
            this.pnlControls1.Padding = new System.Windows.Forms.Padding(5);
            this.pnlControls1.Size = new System.Drawing.Size(808, 40);
            this.pnlControls1.TabIndex = 3;
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.AccessibleName = "Button";
            this.btnSaveChanges.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSaveChanges.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnSaveChanges.Location = new System.Drawing.Point(551, 5);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(121, 30);
            this.btnSaveChanges.Style.BackColor = System.Drawing.Color.Green;
            this.btnSaveChanges.Style.FocusedBackColor = System.Drawing.Color.Green;
            this.btnSaveChanges.Style.FocusedForeColor = System.Drawing.Color.White;
            this.btnSaveChanges.Style.ForeColor = System.Drawing.Color.White;
            this.btnSaveChanges.Style.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(0)))));
            this.btnSaveChanges.Style.HoverForeColor = System.Drawing.Color.White;
            this.btnSaveChanges.Style.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(163)))), ((int)(((byte)(85)))));
            this.btnSaveChanges.Style.PressedForeColor = System.Drawing.Color.White;
            this.btnSaveChanges.TabIndex = 5;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Location = new System.Drawing.Point(672, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(10, 30);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnAddNewTool
            // 
            this.btnAddNewTool.AccessibleName = "Button";
            this.btnAddNewTool.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAddNewTool.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnAddNewTool.Location = new System.Drawing.Point(682, 5);
            this.btnAddNewTool.Name = "btnAddNewTool";
            this.btnAddNewTool.Size = new System.Drawing.Size(121, 30);
            this.btnAddNewTool.Style.BackColor = System.Drawing.Color.Green;
            this.btnAddNewTool.Style.FocusedBackColor = System.Drawing.Color.Green;
            this.btnAddNewTool.Style.FocusedForeColor = System.Drawing.Color.White;
            this.btnAddNewTool.Style.ForeColor = System.Drawing.Color.White;
            this.btnAddNewTool.Style.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(0)))));
            this.btnAddNewTool.Style.HoverForeColor = System.Drawing.Color.White;
            this.btnAddNewTool.Style.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(163)))), ((int)(((byte)(85)))));
            this.btnAddNewTool.Style.PressedForeColor = System.Drawing.Color.White;
            this.btnAddNewTool.TabIndex = 3;
            this.btnAddNewTool.Text = "Add New Tool";
            this.btnAddNewTool.Click += new System.EventHandler(this.btnAddNewTool_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnImportFile);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.btnUpdateStatus);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.btnReload);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(808, 40);
            this.panel1.TabIndex = 2;
            // 
            // btnImportFile
            // 
            this.btnImportFile.AccessibleName = "Button";
            this.btnImportFile.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnImportFile.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnImportFile.Location = new System.Drawing.Point(485, 5);
            this.btnImportFile.Name = "btnImportFile";
            this.btnImportFile.Size = new System.Drawing.Size(104, 30);
            this.btnImportFile.Style.BackColor = System.Drawing.Color.Green;
            this.btnImportFile.Style.FocusedBackColor = System.Drawing.Color.Green;
            this.btnImportFile.Style.FocusedForeColor = System.Drawing.Color.White;
            this.btnImportFile.Style.ForeColor = System.Drawing.Color.White;
            this.btnImportFile.Style.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(0)))));
            this.btnImportFile.Style.HoverForeColor = System.Drawing.Color.White;
            this.btnImportFile.Style.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(163)))), ((int)(((byte)(85)))));
            this.btnImportFile.Style.PressedForeColor = System.Drawing.Color.White;
            this.btnImportFile.TabIndex = 8;
            this.btnImportFile.Text = "Import File";
            this.btnImportFile.Click += new System.EventHandler(this.btnImportFile_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox3.Location = new System.Drawing.Point(589, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(10, 30);
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // btnUpdateStatus
            // 
            this.btnUpdateStatus.AccessibleName = "Button";
            this.btnUpdateStatus.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnUpdateStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnUpdateStatus.Location = new System.Drawing.Point(599, 5);
            this.btnUpdateStatus.Name = "btnUpdateStatus";
            this.btnUpdateStatus.Size = new System.Drawing.Size(104, 30);
            this.btnUpdateStatus.Style.BackColor = System.Drawing.Color.Green;
            this.btnUpdateStatus.Style.FocusedBackColor = System.Drawing.Color.Green;
            this.btnUpdateStatus.Style.FocusedForeColor = System.Drawing.Color.White;
            this.btnUpdateStatus.Style.ForeColor = System.Drawing.Color.White;
            this.btnUpdateStatus.Style.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(0)))));
            this.btnUpdateStatus.Style.HoverForeColor = System.Drawing.Color.White;
            this.btnUpdateStatus.Style.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(163)))), ((int)(((byte)(85)))));
            this.btnUpdateStatus.Style.PressedForeColor = System.Drawing.Color.White;
            this.btnUpdateStatus.TabIndex = 6;
            this.btnUpdateStatus.Text = "Update All";
            this.btnUpdateStatus.Click += new System.EventHandler(this.btnUpdateStatus_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox2.Location = new System.Drawing.Point(703, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(10, 30);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // btnReload
            // 
            this.btnReload.AccessibleName = "Button";
            this.btnReload.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnReload.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnReload.Location = new System.Drawing.Point(713, 5);
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
            this.btnReload.Click += new System.EventHandler(this.txtReload_Click);
            // 
            // txtSearch
            // 
            bannerTextInfo1.Text = "Search Anywhere";
            bannerTextInfo1.Visible = true;
            this.bannerTextProvider1.SetBannerText(this.txtSearch, bannerTextInfo1);
            this.txtSearch.BeforeTouchSize = new System.Drawing.Size(224, 29);
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(5, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(224, 29);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // OtherTools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel3);
            this.Name = "OtherTools";
            this.Size = new System.Drawing.Size(808, 420);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sdgTools)).EndInit();
            this.pnlControls1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel pnlControls1;
        private System.Windows.Forms.Panel panel1;
        private Syncfusion.WinForms.DataGrid.SfDataGrid sdgTools;
        private Syncfusion.WinForms.Controls.SfButton btnSaveChanges;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Syncfusion.WinForms.Controls.SfButton btnAddNewTool;
        private Syncfusion.WinForms.Controls.SfButton btnReload;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtSearch;
        private Syncfusion.Windows.Forms.BannerTextProvider bannerTextProvider1;
        private Syncfusion.WinForms.Controls.SfButton btnUpdateStatus;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Syncfusion.WinForms.Controls.SfButton btnImportFile;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}
