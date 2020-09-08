namespace AdminToolManagementStudio.Controls
{
    partial class CustomerTicketContainer
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
            this.pnlTick = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlTick
            // 
            this.pnlTick.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTick.Location = new System.Drawing.Point(0, 0);
            this.pnlTick.Name = "pnlTick";
            this.pnlTick.Size = new System.Drawing.Size(382, 349);
            this.pnlTick.TabIndex = 0;
            // 
            // CustomerTicketContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlTick);
            this.Name = "CustomerTicketContainer";
            this.Size = new System.Drawing.Size(382, 349);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTick;
    }
}
