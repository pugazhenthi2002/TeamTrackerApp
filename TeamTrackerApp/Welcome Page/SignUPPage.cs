using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamTrackerApp.Welcome_Page
{
    public partial class SignUPPage : UserControl
    {
        public SignUPPage()
        {
            InitializeComponent();

            usernameTextBox.GotFocus += RemoveUserText;
            usernameTextBox.LostFocus += AddUserText;
            yourEmailTextBox.GotFocus += RemoveYourEmailText;
            yourEmailTextBox.LostFocus += AddYourEmailText;
            adminEmailTextBox.GotFocus += RemoveAdminEmailText;
            adminEmailTextBox.LostFocus += AddAdminEmailText;
        }

        public delegate void LoginHandler(Rectangle box, int x);
        public event LoginHandler LoginClick;

        private void OnLoginClicked(object sender, EventArgs e)
        {
            LoginClick?.Invoke(new Rectangle(Width / 2, 0, Width / 2, Height), -18);
        }

        public void RemoveUserText(object sender, EventArgs e)
        {
            if (usernameTextBox.Text == "Username")
            {
                usernameTextBox.Text = "";
            }
        }

        public void AddUserText(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(usernameTextBox.Text))
                usernameTextBox.Text = "Username";
        }

        public void RemoveYourEmailText(object sender, EventArgs e)
        {
            if (yourEmailTextBox.Text == "Your Email")
            {
                yourEmailTextBox.Text = "";
            }
        }

        public void AddYourEmailText(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(yourEmailTextBox.Text))
                yourEmailTextBox.Text = "Your Email";
        }

        public void RemoveAdminEmailText(object sender, EventArgs e)
        {
            if (adminEmailTextBox.Text == "Admin Email")
            {
                adminEmailTextBox.Text = "";
            }
        }

        public void AddAdminEmailText(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(adminEmailTextBox.Text))
                adminEmailTextBox.Text = "Admin Email";
        }

        private void OnSignUpPanelPaint(object sender, PaintEventArgs e)
        {
            Pen p = new Pen(Color.FromArgb(11, 96, 176), 2);
            Point Pt1 = new Point(usernameTextBox.Location.X, usernameTextBox.Location.Y + usernameTextBox.Height +1);
            Point Pt2 = new Point(usernameTextBox.Location.X + usernameTextBox.Width, usernameTextBox.Location.Y + usernameTextBox.Height + 1);
            

            e.Graphics.DrawLine(p, Pt1, Pt2);
            p.Dispose();
        }

        private void AdminEmailPanelPaint(object sender, PaintEventArgs e)
        {
            Pen p = new Pen(Color.FromArgb(11, 96, 176), 2);
            Point Pt1 = new Point(adminEmailTextBox.Location.X, adminEmailTextBox.Location.Y + adminEmailTextBox.Height + 1);
            Point Pt2 = new Point(adminEmailTextBox.Location.X + adminEmailTextBox.Width, adminEmailTextBox.Location.Y + adminEmailTextBox.Height + 1);


            e.Graphics.DrawLine(p, Pt1, Pt2);
            p.Dispose();
        }

        private void YourEmailPanelPaint(object sender, PaintEventArgs e)
        {
            Pen p = new Pen(Color.FromArgb(11, 96, 176), 2);
            Point Pt1 = new Point(yourEmailTextBox.Location.X, yourEmailTextBox.Location.Y + yourEmailTextBox.Height + 1);
            Point Pt2 = new Point(yourEmailTextBox.Location.X + yourEmailTextBox.Width, yourEmailTextBox.Location.Y + yourEmailTextBox.Height + 1);


            e.Graphics.DrawLine(p, Pt1, Pt2);
            p.Dispose();
        }
    }
}
