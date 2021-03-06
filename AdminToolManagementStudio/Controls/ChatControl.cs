﻿using System;
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
    public partial class ChatControl : UserControl
    {
        public MessageType MessageType { get; set; }
        public delegate void MessageSendRequest(Models.Message message);

        public event MessageSendRequest SendMessage;

        public ChatControl()
        {
            InitializeComponent();
        }

        public void LoadAllMessages(List<Models.Message> messages)
        {
            stackPanel1.Controls.Clear();
            foreach (var message in messages.OrderBy(x => x.Time))
            {
                stackPanel1.Controls.Add(new Message(message));
            }
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
