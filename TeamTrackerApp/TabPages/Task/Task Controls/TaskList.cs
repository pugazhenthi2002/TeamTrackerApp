using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamTrackerApp.TabPages.Task.Task_Controls
{
    public partial class TaskList : UserControl
    {
        public Color TaskListColor
        {
            get
            {
                return sidePanel.BackColor;
            }
            set
            {
                sidePanel.BackColor = projectDateLabel.ForeColor = projectNameLabel.ForeColor = value;
            }
        }

        public Project AssignedProject
        {
            set
            {
                this.SuspendLayout();
                GenerateTask(value.SubmittedProjectCollection);
                projectNameLabel.Text = value.ProjectName;
                projectDateLabel.Text = value.StartDate.ToShortDateString() + " - " + value.LastDate.ToShortDateString();
                this.ResumeLayout();
            }
        }
        public TaskList()
        {
            InitializeComponent();
        }

        private Label SetLabel(string str)
        {
            Label label = new Label();
            label.MouseEnter += RowHighLightEnter;
            label.MouseLeave += RowHighLightLeave;
            label.Dock = DockStyle.Fill;
            label.AutoSize = false;
            label.Margin = new Padding(0);
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.Font = new Font(new FontFamily("Consolas"), 9);
            label.Text = str;
            return label;
        }

        private AnimatedLabel SetLabel(Status status)
        {
            AnimatedLabel label = new AnimatedLabel();
            label.MouseEnter += RowHighLightEnter;
            label.MouseLeave += RowHighLightLeave;
            label.Dock = DockStyle.Fill;
            label.AutoSize = false;
            label.Font = new Font(new FontFamily("Consolas"), 9);
            label.Margin = new Padding(0, 0, 0, 1);
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.Text = status.ToString();
            label.Click += StatusChanged;

            if (status == Status.Done)
            {
                label.BackColor = Color.LimeGreen;
            }

            if (status == Status.Stuck)
            {
                label.BackColor = Color.Red;
            }

            if (status == Status.WorkingOnIt)
            {
                label.BackColor = Color.Gold;
            }

            if (status == Status.NotStarted)
            {
                label.BackColor = Color.Gray;
            }

            return label;
        }

        private AnimatedLabel SetLabel(Priority priority)
        {
            AnimatedLabel label = new AnimatedLabel();
            label.MouseEnter += RowHighLightEnter;
            label.MouseLeave += RowHighLightLeave; 
            label.Dock = DockStyle.Fill;
            label.AutoSize = false;
            label.Font = new Font(new FontFamily("Consolas"), 9);
            label.Margin = new Padding(0, 0, 0, 1);
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.Text = priority.ToString();
            label.Click += PriorityChanged;

            if (priority == Priority.Critical)
            {
                label.BackColor = Color.Gray;
            }

            if (priority == Priority.High)
            {
                label.BackColor = Color.Indigo;
            }

            if (priority == Priority.Medium)
            {
                label.BackColor = Color.Blue;
            }

            if (priority == Priority.Low)
            {
                label.BackColor = Color.SkyBlue;
            }
            label.ForeColor = Color.White;
            return label;
        }

        private Button SetView()
        {
            Button b = new Button();
            b.MouseEnter += RowHighLightEnter;
            b.MouseLeave += RowHighLightLeave;
            b.Dock = DockStyle.Fill;
            return b;
        }

        private void OnOverallStatusPaint(object sender, PaintEventArgs e)
        {
            buttonWidth = overallStatusPanel.Width;
            Rectangle doneRec, notStartRec, workingRec, stuckRec;
            doneRec = new Rectangle(0, 0, buttonWidth * doneCount / totalCount, Height);
            notStartRec = new Rectangle(doneRec.Width, 0, buttonWidth * workingCount / totalCount, Height);
            workingRec = new Rectangle(notStartRec.X + notStartRec.Width, 0, buttonWidth * notStartedCount / totalCount, Height);
            stuckRec = new Rectangle(workingRec.X + workingRec.Width, 0, buttonWidth * stuckCount / totalCount, Height);

            Brush b1, b2, b3, b4;
            b1 = new SolidBrush(Color.LimeGreen); b2 = new SolidBrush(Color.Gray); b3 = new SolidBrush(Color.Gold); b4 = new SolidBrush(Color.Red);

            e.Graphics.FillRectangle(b1, doneRec);
            e.Graphics.FillRectangle(b2, notStartRec);
            e.Graphics.FillRectangle(b3, workingRec);
            e.Graphics.FillRectangle(b4, stuckRec);

            b1.Dispose(); b2.Dispose(); b3.Dispose(); b4.Dispose();
        }

        private void OnOverallPriorityPaint(object sender, PaintEventArgs e)
        {
            buttonWidth = overallPriorityPanel.Width;
            Rectangle criticRec, highRec, mediumRec, easyRec;
            criticRec = new Rectangle(0, 0, buttonWidth * criticCount / totalCount, Height);
            highRec = new Rectangle(criticRec.Width, 0, buttonWidth * hardCount / totalCount, Height);
            mediumRec = new Rectangle(highRec.X + highRec.Width, 0, buttonWidth * mediumCount / totalCount, Height);
            easyRec = new Rectangle(mediumRec.X + mediumRec.Width, 0, buttonWidth * easyCount / totalCount, Height);

            Brush b1, b2, b3, b4;
            b1 = new SolidBrush(Color.Gray); b2 = new SolidBrush(Color.Indigo); b3 = new SolidBrush(Color.Blue); b4 = new SolidBrush(Color.SkyBlue);


            e.Graphics.FillRectangle(b1, criticRec);
            e.Graphics.FillRectangle(b2, highRec);
            e.Graphics.FillRectangle(b3, mediumRec);
            e.Graphics.FillRectangle(b4, easyRec);

            b1.Dispose(); b2.Dispose(); b3.Dispose(); b4.Dispose();
        }

        private void StatusChanged(object sender, EventArgs e)
        {
            StatusDropDown statusForm = new StatusDropDown();
            statusForm.Location = SetLocation((sender as AnimatedLabel).PointToScreen(new Point((sender as AnimatedLabel).Width, (sender as AnimatedLabel).Height)));
            statusForm.Show();
        }

        private void PriorityChanged(object sender, EventArgs e)
        {

        }

        private void GenerateTask(List<Task> taskCollection)
        {
            int rows = taskCollection.Count;
            Height = 120 + (50 * (rows + 1));
            int ctr = 1;
            taskTableLayoutPanel.RowCount = rows + 1;
            totalCount = rows;
            foreach (var Iter in taskCollection)
            {
                taskTableLayoutPanel.Controls.Add(SetView(), 6, ctr);
                taskTableLayoutPanel.Controls.Add(SetLabel(Iter.LastUpdate.ToShortDateString()), 5, ctr);
                taskTableLayoutPanel.Controls.Add(SetLabel(Iter.TaskPriority), 4, ctr);
                taskTableLayoutPanel.Controls.Add(SetLabel(Iter.TaskDueDate.ToShortDateString()), 3, ctr);
                taskTableLayoutPanel.Controls.Add(SetLabel(Iter.StatusOfTask), 2, ctr);
                taskTableLayoutPanel.Controls.Add(SetLabel(Iter.ProjectLeadName), 1, ctr);
                taskTableLayoutPanel.Controls.Add(SetLabel(Iter.TaskName), 0, ctr);
                taskTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50));
                ctr++;

                if (Iter.StatusOfTask == Status.Done) doneCount++;
                if (Iter.StatusOfTask == Status.WorkingOnIt) workingCount++;
                if (Iter.StatusOfTask == Status.NotStarted) notStartedCount++;
                if (Iter.StatusOfTask == Status.Stuck) stuckCount++;
                if (Iter.TaskPriority == Priority.Critical) criticCount++;
                if (Iter.TaskPriority == Priority.High) hardCount++;
                if (Iter.TaskPriority == Priority.Medium) mediumCount++;
                if (Iter.TaskPriority == Priority.Low) easyCount++;
            }
            overallPriorityPanel.Invalidate();
            overallStatusPanel.Invalidate();
        }

        private void RowHighLightEnter(object sender, EventArgs e)
        {
            int row = -1;
            row = taskTableLayoutPanel.GetPositionFromControl((sender as Control)).Row;
            taskTableLayoutPanel.GetControlFromPosition(0, row).BackColor = Color.FromArgb(220, 207, 196);
            taskTableLayoutPanel.GetControlFromPosition(1, row).BackColor = Color.FromArgb(220, 207, 196);
            taskTableLayoutPanel.GetControlFromPosition(3, row).BackColor = Color.FromArgb(220, 207, 196);
            taskTableLayoutPanel.GetControlFromPosition(5, row).BackColor = Color.FromArgb(220, 207, 196);
            taskTableLayoutPanel.GetControlFromPosition(6, row).BackColor = Color.FromArgb(220, 207, 196);
            
        }

        private void RowHighLightLeave(object sender, EventArgs e)
        {
            int row = -1;
            row = taskTableLayoutPanel.GetPositionFromControl((sender as Control)).Row;

            taskTableLayoutPanel.GetControlFromPosition(0, row).BackColor = Color.FromArgb(235, 222, 211);
            taskTableLayoutPanel.GetControlFromPosition(1, row).BackColor = Color.FromArgb(235, 222, 211);
            taskTableLayoutPanel.GetControlFromPosition(3, row).BackColor = Color.FromArgb(235, 222, 211);
            taskTableLayoutPanel.GetControlFromPosition(5, row).BackColor = Color.FromArgb(235, 222, 211);
            taskTableLayoutPanel.GetControlFromPosition(6, row).BackColor = Color.FromArgb(235, 222, 211);
        }

        private Point SetLocation(Point Pt)
        {
            Point loc = new Point(Math.Abs(Pt.X - 200), Pt.Y);
            Size screenSize = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            if (Pt.Y + 300 >= screenSize.Height)
            {
                loc = new Point(loc.X, screenSize.Height - 300 - 30);
            }
            return loc;
        }
        private int buttonWidth;
        private int totalCount;
        private int doneCount, workingCount, notStartedCount, stuckCount;
        private int criticCount, hardCount, mediumCount, easyCount;
    }
}
