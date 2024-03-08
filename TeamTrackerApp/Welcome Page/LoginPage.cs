using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace TeamTrackerApp
{
    public partial class LoginPage : UserControl
    {
        public LoginPage()
        {
            InitializeComponent();

            usernameTextBox.GotFocus += RemoveUserText;
            usernameTextBox.LostFocus += AddUserText;
            PasswordTextBox.GotFocus += RemovePassText;
            PasswordTextBox.LostFocus += AddPassText;
        }

        public delegate void LoginHandler(Rectangle box, int x);
        public event LoginHandler NewUserClick;

        private void newUserLabelClicked(object sender, EventArgs e)
        {
            NewUserClick?.Invoke(new Rectangle(0, 0, Width / 2, Height), 18);
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

        public void RemovePassText(object sender, EventArgs e)
        {
            if (PasswordTextBox.Text == "Password")
            {
                PasswordTextBox.PasswordChar = '*';
                PasswordTextBox.Text = "";
            }
        }

        public void AddPassText(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PasswordTextBox.Text))
            {
                PasswordTextBox.PasswordChar = '\0';
                PasswordTextBox.Text = "Password";
            }
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
            LoginSubmit.Focus();
            usernameTextBox.Focus();
        }

        private void usernamePanelPaint(object sender, PaintEventArgs e)
        {
            Pen p = new Pen(Color.FromArgb(11, 96, 176), 2);
            Point Pt1 = new Point(usernameTextBox.Location.X, usernameTextBox.Location.Y + usernameTextBox.Height + 1);
            Point Pt2 = new Point(usernameTextBox.Location.X + usernameTextBox.Width, usernameTextBox.Location.Y + usernameTextBox.Height + 1);


            e.Graphics.DrawLine(p, Pt1, Pt2);
            p.Dispose();
        }

        private void PasswordPanelPaint(object sender, PaintEventArgs e)
        {
            Pen p = new Pen(Color.FromArgb(11, 96, 176), 2);
            Point Pt1 = new Point(PasswordTextBox.Location.X, PasswordTextBox.Location.Y + PasswordTextBox.Height + 1);
            Point Pt2 = new Point(PasswordTextBox.Location.X + PasswordTextBox.Width, PasswordTextBox.Location.Y + PasswordTextBox.Height + 1);


            e.Graphics.DrawLine(p, Pt1, Pt2);
            p.Dispose();
        }

        private void OnLoggedIn(object sender, EventArgs e)
        {

        }
    }
}
