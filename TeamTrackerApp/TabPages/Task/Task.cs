using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamTrackerApp.TabPages.Task
{
    public enum Status
    {
        NotStarted,
        WorkingOnIt,
        Stuck,
        Done
    }

    public enum Priority
    {
        Low,
        Medium,
        High,
        Critical
    }

    public class Task
    {
        public int TaskID;
        public string TaskName;
        public int ProjectLeadID;
        public string ProjectLeadName;
        public Status StatusOfTask;
        public DateTime TaskDueDate;
        public Priority TaskPriority;
        public DateTime LastUpdate;
        public List<string> SubmittedTaskCollection;

        public Task()
        {
            SubmittedTaskCollection = new List<string>();
        }

        public void SubmitTask(string str)
        {
            SubmittedTaskCollection.Add(str);
        }
    }
}
