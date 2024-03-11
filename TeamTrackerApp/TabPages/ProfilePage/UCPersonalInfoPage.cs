using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamTrackerApp.TabPages.ProfilePage
{
    public partial class UCPersonalInfoPage : UserControl
    {
        public UCPersonalInfoPage()
        {
            InitializeComponent();
        }

        private void OnResize(object sender, EventArgs e)
        {

            pictureBox1.Size = new Size();
            pictureBox2.Size = new Size();
            pictureBox3.Size = new Size();
            pictureBox4.Size = new Size();
            pictureBox5.Size = new Size();


            textBox1.Size = new Size();
            textBox2.Size = new Size();
            textBox3.Size = new Size();
            textBox4.Size = new Size();
            textBox5.Size = new Size();


        }

        private void UCPersonalInfoPage_Load(object sender, EventArgs e)
        {

        }
    }
}
