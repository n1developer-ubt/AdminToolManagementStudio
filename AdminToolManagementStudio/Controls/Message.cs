using System;
using System.Drawing;
using System.Windows.Forms;
using AdminToolManagementStudio.Models;
using Syncfusion.Data.Extensions;

namespace AdminToolManagementStudio.Controls
{
    public partial class Message : UserControl
    {
        private Models.Message CurrentMessage;
        public static string CustomerName;
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

            var size = MeasureString(lblText.Text, new Font("Microsoft Sans Serif,", 12, FontStyle.Regular), new Size(panel3.Width, 100000));

            this.Height = Height - panel3.Height + (int)size.Height + 10;
        }

        public void LoadMessage(Models.Message m)
        {
            if (m == null) return;
            m.Text = Join(m.Text.Trim());
            CurrentMessage = m;

            pnlTop.BackColor = CurrentMessage.Type == MessageType.Admin
                ? Color.FromArgb(0, 71, 64)
                : Color.FromArgb(37, 45, 49);
            lblDate.Text = m.Time.ToString("G");
            lblName.Text = m.Type == MessageType.Admin ? "Admin" : CustomerName;
            lblText.Text = m.Text;
            
            var size = MeasureString(lblText.Text, new Font("Microsoft Sans Serif,", 12, FontStyle.Regular), new Size(panel3.Width, 100000));

            this.Height = Height - panel3.Height + (int)size.Height + 10;
            //MessageBox.Show(lblText.Text);
        }

        private string Join(string s)
        {
            if (s.StartsWith("Subject")) return s;

            var x = s.Split('\n','\r');

            string y = "";

            x.ForEach(l =>
            {
                if (l.Trim().Equals(""))
                    return;

                y += l + " ";
            });

            return y.Trim();
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
