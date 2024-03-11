using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamTrackerApp.TabPages.Colloborate.Colloborate_Control
{
    public partial class ColloborateMessageBox : UserControl
    {
        public ColloborateMessageBox()
        {
            InitializeComponent();
            DoubleBuffered = true;
            MessageTextBox.GotFocus += RemoveUserText;
            MessageTextBox.LostFocus += AddUserText;
        }

        public void RemoveUserText(object sender, EventArgs e)
        {
            if (MessageTextBox.Text == "Type Message Here ..")
            {
                MessageTextBox.Text = "";
                MessageTextBox.ForeColor = Color.Black;
            }
        }

        public void AddUserText(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(MessageTextBox.Text))
            {
                MessageTextBox.ForeColor = Color.Gray;
                MessageTextBox.Text = "Type Message Here ..";
            }
        }

        private void OnFileAttachClick(object sender, EventArgs e)
        {
            fileAttachDialog.ShowDialog();
        }

        private void OnAudioAttachClick(object sender, EventArgs e)
        {
            audioAttachDialogue.ShowDialog();
        }

        private void OnSentMessageClick(object sender, EventArgs e)
        {

        }
    }
}
