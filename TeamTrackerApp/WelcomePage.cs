using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamTrackerApp
{
    public partial class WelcomePage : UserControl
    {
        public WelcomePage()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }

        private void OnPageSwitch(Rectangle box, int x)
        {
            this.box = box;
            movementX = x;
            loginPage1.Visible = false;
            pageSwitchTimer.Start();
        }

        private void pageSwitchTick(object sender, EventArgs e)
        {
            if(movementX<0)
            {

            }
            else
            {
                box = new Rectangle(box.X + movementX, box.Y, box.Width, box.Height);
                if (box.X+box.Width>Width)
                {
                    box = new Rectangle(Width - box.Width, box.Y, box.Width, box.Height);
                    pageSwitchTimer.Stop();
                }
                this.Invalidate();
            }
        }

        private Rectangle box;
        private int movementX;

        private void WelcomePagePaint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(11, 96, 176)), box);
        }
    }
}
