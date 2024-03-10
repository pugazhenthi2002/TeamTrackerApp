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
    public partial class ChatMoreDropDown : Form
    {
        public ChatMoreDropDown()
        {
            InitializeComponent();
        }

        public event EventHandler<string> ChatMoreChanged;
        private void OnMoreOptionClicked(object sender, EventArgs e)
        {
            if((sender as PictureBox).Name == "mutePictureBox" || (sender as Label).Text == "Mute")
            {
                ChatMoreChanged?.Invoke(this, "Mute");
            }
            else
            {
                ChatMoreChanged?.Invoke(this, "Delete");
            }
            this.Close();
        }

        private void OnCloseClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OnDropDownFormLoad(object sender, EventArgs e)
        {
            endLocation = Location;
            Location = new Point(endLocation.X, endLocation.Y - 20);
            formLoadTimer.Start();
        }

        private void OnFormOpenTick(object sender, EventArgs e)
        {
            Location = new Point(Location.X, Location.Y + 1);
            if(this.Location.Y >= endLocation.Y)
            {
                formLoadTimer.Stop();
            }
        }

        private Point endLocation;
    }
}
