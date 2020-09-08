using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void OnSizeChanged(object sender, EventArgs e)
        {
            LoadMessage(CurrentMessage);
        }

        public void LoadMessage(Models.Message m)
        {
            if (m == null) return;
            CurrentMessage = m;

            var size = MeasureString(m.Text, new Font("Microsoft Sans Serif,", 12, FontStyle.Regular), new Size(panel3.Width, 1000));

            Console.WriteLine("S: "+size.Width+"-"+size.Height);
            Console.WriteLine("P: "+this.Size.Width+"-"+Size.Height);

            this.Height = Height - panel3.Height + (int)size.Height+5;
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
