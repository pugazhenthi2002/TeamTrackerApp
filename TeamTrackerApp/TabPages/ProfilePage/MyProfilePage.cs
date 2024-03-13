using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamTrackerApp.TabPages.ProfilePage
{
    public partial class MyProfilePage : Form
    {
        public MyProfilePage()
        {
            InitializeComponent();
        }

        private void MyProfilePage_Load(object sender, EventArgs e)
        {

        }

        private void OnClickPersonalInfo(object sender, EventArgs e)
        {
            ProfileTabControl.SelectedTab = tabPage1;
        }

        private void OnClickWorkingStatus(object sender, EventArgs e)
        {
            ProfileTabControl.SelectedTab = tabPage2;
        }

        private void OnClickPassword(object sender, EventArgs e)
        {
            ProfileTabControl.SelectedTab = tabPage3;
        }

        private void OnClickLanguageRegion(object sender, EventArgs e)
        {
            ProfileTabControl.SelectedTab = tabPage4;
        }

        private void OnClickClose(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
