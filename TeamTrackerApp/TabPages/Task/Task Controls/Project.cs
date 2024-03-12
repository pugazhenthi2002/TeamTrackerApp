using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamTrackerApp.TabPages.Task.Task_Controls
{
    public class Project
    {
        public int ProjectID;
        public string ProjectName;
        public DateTime StartDate;
        public DateTime LastDate;
        public List<Task> SubmittedProjectCollection;
    }
}
