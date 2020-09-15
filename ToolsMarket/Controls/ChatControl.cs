using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ToolsMarket.Models;

namespace ToolsMarket.Controls
{
    public partial class ChatControl : UserControl
    {
        public MessageType MessageType { get; set; }
        public delegate void MessageSendRequest(Models.Message message);

        public event MessageSendRequest SendMessage;

        public ChatControl()
        {
            InitializeComponent();
            Enabled = false;
        }

        public void LoadAllMessages(List<Models.Message> messages)
        {
            stackPanel1.Controls.Clear();
            Enabled = true;
            foreach (var message in messages.OrderBy(x => x.Time))
            {
                stackPanel1.Controls.Add(new Message(message));
            }
        }

        public void Clear()
        {
            stackPanel1.Controls.Clear();
            Enabled = false;
        }

        private async void btnSend_Click(object sender, EventArgs e)
        {
            if(!(sender is Control c )) return;

            c.Enabled = false;

            var message = new Models.Message()
            {
                Text = txtNewMessage.Text.Trim(),
                Type = MessageType,
                Time = DateTime.Now
            };

            var m = new Message(message);
            stackPanel1.Controls.Add(m);
            stackPanel1.ScrollControlIntoView(m);
            SendMessage?.Invoke(message);
            txtNewMessage.Text = "";
            c.Enabled = true;
        }

        private void txtNewMessage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && e.Control)
            {
                btnSend_Click(sender,e);
            }
        }
    }
}
