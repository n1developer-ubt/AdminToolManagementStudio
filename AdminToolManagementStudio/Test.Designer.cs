namespace AdminToolManagementStudio
{
    partial class Test
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
            this.message1 = new AdminToolManagementStudio.Controls.Message();
            this.SuspendLayout();
            // 
            // message1
            // 
            this.message1.BackColor = System.Drawing.Color.White;
            this.message1.Dock = System.Windows.Forms.DockStyle.Top;
            this.message1.Location = new System.Drawing.Point(0, 0);
            this.message1.Name = "message1";
            this.message1.Size = new System.Drawing.Size(723, 217);
            this.message1.TabIndex = 0;
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 437);
            this.Controls.Add(this.message1);
            this.Name = "Test";
            this.Text = "Test";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.Message message1;
    }
}