using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamTrackerApp
{
    class PlaceHolderTextBox: TextBox
    {
        public string PlaceHolder { get; set; }
        public bool IsPasswordType { get; set; }
        int cnt = 0;
        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);
            if (Text == PlaceHolder)
            {
                cnt++;
                if(IsPasswordType)
                PasswordChar = '*';
                Text = "";
            }
        }

        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);
            if (string.IsNullOrWhiteSpace(Text))
            {
                if(IsPasswordType)
                PasswordChar = '\0';
                Text = PlaceHolder;
            }
        }
    }
}
