using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamTrackerApp.TabPages.Colloborate.Colloborate_Control
{
    public partial class ChatProfile : UserControl
    {
        public ChatProfile()
        {
            InitializeComponent();
        }

        public event EventHandler<int> ProfileInfoClick;

        private void OnInfoClicked(object sender, EventArgs e)
        {
            ProfileInfoClick?.Invoke(this, 1);
        }

        private void OnMoreOptionClicked(object sender, EventArgs e)
        {
            Point Pt = new Point(-25, (sender as PictureBox).Location.Y + (sender as PictureBox).Height + 10);
            Pt = (sender as PictureBox).PointToScreen(Pt);
            ChatMoreDropDown newDropDown = new ChatMoreDropDown();
            newDropDown.Location = Pt;
            newDropDown.Show();
        }
    }
}
