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
    public partial class UCSignUp : UserControl
    {

       
        public UCSignUp()
        {
            InitializeComponent();

            UserNameTextBox.Text = UserNameTextBox.Tag.ToString();
            UserEmailTextBox.Text = UserEmailTextBox.Tag.ToString();
            ReferalEmailTextBox.Text = ReferalEmailTextBox.Tag.ToString();


            UserNameTextBox.LostFocus += LostFocusTextBox;
            UserEmailTextBox.LostFocus += LostFocusTextBox;
            ReferalEmailTextBox.LostFocus+= LostFocusTextBox;
            
        }


        private string UserName;
        private string UserEmail;
        private string ReferalEmail;


       

        private void LostFocusTextBox(object sender, EventArgs e)
        {
            TextBox textBox1 = sender as TextBox;

            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.Text = textBox1.Tag.ToString();
                textBox1.ForeColor = Color.Gray;
            }
        }

        private void OnClickTextBox(object sender, EventArgs e)
        {
            if("Enter UserName Enter Email Id Enter Referal Email Id".Contains((sender as TextBox).Text))
            {
                (sender as TextBox).Text = "";
            }
        }

        private void OnMouseEnterGoBackLabel(object sender, EventArgs e)
        {
            GoBackLabel.Font = new Font(GoBackLabel.Font, FontStyle.Bold);

        }

        private void OnMouseLeaveGoBackLabel(object sender, EventArgs e)
        {
            GoBackLabel.Font = new Font(GoBackLabel.Font, FontStyle.Regular);
        }

        private void OnClickGetRequestBtn(object sender, EventArgs e)
        {
            UserName = UserNameTextBox.Text;
            UserEmail = UserEmailTextBox.Text;
            ReferalEmail = ReferalEmailTextBox.Text;
        }

    }
}
