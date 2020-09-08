using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdminToolManagementStudio.Models;

namespace AdminToolManagementStudio.Controls
{
    public partial class Message : UserControl
    {
        private Models.Message CurrentMessage;
        public Message()
        {
            InitializeComponent();
            SizeChanged += OnSizeChanged;
        }

        public Message(Models.Message m) : this()
        {
            LoadMessage(m);
        }

        private void OnSizeChanged(object sender, EventArgs e)
        {
            if (lblText == null)
                return;

            var size = MeasureString(lblText.Text, new Font("Microsoft Sans Serif,", 12, FontStyle.Regular), new Size(panel3.Width, 1000));

            //Console.WriteLine("S: " + size.Width + "-" + size.Height);
            //Console.WriteLine("P: " + this.Size.Width + "-" + Size.Height);


            this.Height = Height - panel3.Height + (int)size.Height + 5;
        }

        public void LoadMessage(Models.Message m)
        {
            if (m == null) return;
            CurrentMessage = m;

            pnlTop.BackColor = CurrentMessage.Type == MessageType.Admin
                ? Color.FromArgb(0, 71, 64)
                : Color.FromArgb(37, 45, 49);
            lblDate.Text = m.Time.ToString("d");
            lblName.Text = m.Name;
            lblText.Text = m.Text;
        }

        public static SizeF MeasureString(string s, Font font, Size sx)
        {
            SizeF result;
            using (var image = new Bitmap(1, 1))
            {
                using (var g = Graphics.FromImage(image))
                {
                    result = g.MeasureString(s, font, sx);
                }
            }

            return result;
        }
    }
}
