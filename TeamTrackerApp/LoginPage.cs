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
        }

        public delegate void LoginHandler(Rectangle box, int x);
        public event LoginHandler NewUserClick;

        private void newUserLabelClicked(object sender, EventArgs e)
        {
            NewUserClick?.Invoke(new Rectangle(0, 0, Width / 2, Height), 12);
        }
    }
}
