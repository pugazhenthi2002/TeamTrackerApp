using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeamTrackerApp.TabPages.Task.Task_Controls;

namespace TeamTrackerApp.TabPages.Task
{
    public enum TaskListColor
    {
        Blue,
        Green,
        Red,
        Orange
    }

    public partial class ProjectView : UserControl
    {
        public ProjectView()
        {
            InitializeComponent();
        }

        private void ProjectView_Load(object sender, EventArgs e)
        {
            
        }

        private void rippleButton1_Click(object sender, EventArgs e)
        {
            projectViewPanel.SuspendLayout();
            int ctr = 0;
            foreach (var Iter in TaskManager.ProjectCollection)
            {
                TaskList newTaskList = new TaskList();
                newTaskList.AssignedProject = Iter;
                newTaskList.TaskListColor = Color.FromName(((TaskListColor)(ctr % 4)).ToString());
                newTaskList.Dock = DockStyle.Top;
                Panel panel = new Panel();
                panel.Height = 10;
                panel.BackColor = Color.AliceBlue;
                panel.Dock = DockStyle.Top;
                projectViewPanel.Controls.Add(newTaskList);
                projectViewPanel.Controls.Add(panel);
                ctr++;
            }
            projectViewPanel.ResumeLayout();
        }
    }
}
