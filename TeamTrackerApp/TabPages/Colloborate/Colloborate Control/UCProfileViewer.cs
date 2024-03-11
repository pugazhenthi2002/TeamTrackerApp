using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamTrackerApp.TabPages.Colloborate.Colloborate_Control
{
    public partial class UCProfileViewer : UserControl
    {
        public UCProfileViewer()
        {
            InitializeComponent();
        }

        private void OnChangeToggleBtn(object sender, EventArgs e)
        {
            if(toggleButton1.Checked)
            {
                MuteLabel.Text = "UnMute";
            }
            else
            {
                MuteLabel.Text = "Mute";
            }
        }

        private void OnClickClose(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void OnMouseEnter(object sender, EventArgs e)
        {
            (sender as Label).Font = new Font("Verdana", 10, FontStyle.Bold);
        }
        private void OnMouseLeave(object sender , EventArgs e)
        {
            (sender as Label).Font = new Font("Verdana", 10, FontStyle.Regular);
        }
    }
}
