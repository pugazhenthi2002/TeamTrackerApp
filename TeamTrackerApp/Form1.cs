using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamTrackerApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.SetProperty, null, panel21, new object[] { true });
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.SetProperty, null, HeaderPanel, new object[] { true });

            
        }

        private void TeamTrackerFormLoad(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void FormHeaderPaint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Gray, 2);
            Rectangle rec = (sender as Panel).ClientRectangle;
            e.Graphics.DrawLine(pen, new Point(rec.X, rec.Y + rec.Height), new Point(rec.X + rec.Width, rec.Y + rec.Height));
            pen.Dispose();
        }

        private void OnNotificationClick(object sender, EventArgs e)
        {
            notificationPictureBox.Image = Properties.Resources.No_Notification;
        }

        private void TeamTrackerAppClose(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OnMouseEnter(object sender, EventArgs e)
        {
            (sender as PictureBox).BackColor = Color.FromArgb(232, 217, 207);
        }

        private void OnMouseLeave(object sender, EventArgs e)
        {
            (sender as PictureBox).BackColor = Color.FromArgb(245, 232, 221);
        }

        private void OnMenuClicked(object sender, EventArgs e)
        {
            SubMenuPanelTimer.Start();
            isSubMenuPanelVisible = !isSubMenuPanelVisible;
        }

        private void OnSubMenuPanelMovement(object sender, EventArgs e)
        {
            if (isSubMenuPanelVisible)
            {
                SubMenuTabelPanel.Width = SubMenuTabelPanel.Width + 20;

                if(SubMenuTabelPanel.Width >= 200)
                {
                    SubMenuTabelPanel.Width = 200;
                    SubMenuPanelTimer.Stop();
                }
            }
            else
            {
                SubMenuTabelPanel.Width = SubMenuTabelPanel.Width - 20;

                if (SubMenuTabelPanel.Width <=0)
                {
                    SubMenuTabelPanel.Width = 0;
                    SubMenuPanelTimer.Stop();
                }
            }
        }

        private bool isSubMenuPanelVisible;
    }
}
