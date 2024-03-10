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
    public partial class ColloborateSearchBar : UserControl
    {
        public ColloborateSearchBar()
        {
            InitializeComponent();
            searchTextBox.GotFocus += RemoveSearchText;
            searchTextBox.LostFocus += AddSearchText;
        }

        private void OnSearchBarResize(object sender, EventArgs e)
        {
            panel1.Width = panel1.Height;
            panel2.Padding = new Padding(0, Height * 3 / 10, 0, Height * 3 / 10);
        }

        public void RemoveSearchText(object sender, EventArgs e)
        {
            if (searchTextBox.Text == "Search Here..")
            {
                searchTextBox.Text = "";
            }
        }

        public void AddSearchText(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(searchTextBox.Text))
                searchTextBox.Text = "Search Here..";
        }

        private void OnSearchEnter(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.FromArgb(38, 80, 115);
        }

        private void OnSearchLeave(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.FromArgb(38, 122, 150);
        }
    }
}
