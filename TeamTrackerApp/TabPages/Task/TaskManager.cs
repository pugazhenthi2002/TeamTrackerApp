using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamTrackerApp.TabPages.Task.Task_Controls;

namespace TeamTrackerApp.TabPages.Task
{
    static class TaskManager
    {
        static TaskManager()
        {
            AssignProject1();
            AssignProject2();
            AssignProject3();
        }

        private static void AssignProject3()
        {
            TaskCollection = new List<Task>();
            Task task1 = new Task()
            {
                TaskID = 1,
                TaskName = "Close Button",
                ProjectLeadID = 101,
                ProjectLeadName = "Murugan",
                StatusOfTask = Status.Done,
                TaskDueDate = new DateTime(2024, 03, 02),
                TaskPriority = Priority.Low,
                LastUpdate = new DateTime(2024, 03, 01),
                SubmittedTaskCollection = new List<string>()
                {
                    "Created",
                    "Updated"
                }
            };
            Task task2 = new Task()
            {
                TaskID = 2,
                TaskName = "Animation Loader",
                ProjectLeadID = 101,
                ProjectLeadName = "Dhadiyan",
                StatusOfTask = Status.WorkingOnIt,
                TaskDueDate = new DateTime(2024, 02, 28),
                TaskPriority = Priority.Critical,
                LastUpdate = new DateTime(2024, 02, 28)
            };
            Task task3 = new Task()
            {
                TaskID = 3,
                TaskName = "Notification",
                ProjectLeadID = 101,
                ProjectLeadName = "Murugan",
                StatusOfTask = Status.Done,
                TaskDueDate = new DateTime(2024, 02, 28),
                TaskPriority = Priority.Critical,
                LastUpdate = new DateTime(2024, 02, 27)
            };
            Task task4 = new Task()
            {
                TaskID = 2,
                TaskName = "Animation Loader",
                ProjectLeadID = 101,
                ProjectLeadName = "Dhadiyan",
                StatusOfTask = Status.NotStarted,
                TaskDueDate = new DateTime(2024, 02, 28),
                TaskPriority = Priority.Medium,
                LastUpdate = new DateTime(2024, 02, 28)
            };
            Task task5 = new Task()
            {
                TaskID = 3,
                TaskName = "Notification",
                ProjectLeadID = 101,
                ProjectLeadName = "Murugan",
                StatusOfTask = Status.Stuck,
                TaskDueDate = new DateTime(2024, 02, 28),
                TaskPriority = Priority.High,
                LastUpdate = new DateTime(2024, 02, 27)
            };
            TaskCollection.Add(task1);
            TaskCollection.Add(task2);
            TaskCollection.Add(task3);
            TaskCollection.Add(task4);
            TaskCollection.Add(task5);

            Project P = new Project()
            {
                ProjectID = 1001,
                ProjectName = "Pedestrian Detection",
                StartDate = new DateTime(2023, 11, 29),
                LastDate = new DateTime(2024, 01, 05),
                SubmittedProjectCollection = TaskCollection
            };
            ProjectCollection.Add(P);
        }

        private static void AssignProject2()
        {
            TaskCollection = new List<Task>();
            Task task1 = new Task()
            {
                TaskID = 1,
                TaskName = "Close Button",
                ProjectLeadID = 101,
                ProjectLeadName = "Murugan",
                StatusOfTask = Status.Done,
                TaskDueDate = new DateTime(2024, 03, 02),
                TaskPriority = Priority.Low,
                LastUpdate = new DateTime(2024, 03, 01),
                SubmittedTaskCollection = new List<string>()
                {
                    "Created",
                    "Updated"
                }
            };
            Task task2 = new Task()
            {
                TaskID = 2,
                TaskName = "Animation Loader",
                ProjectLeadID = 101,
                ProjectLeadName = "Dhadiyan",
                StatusOfTask = Status.WorkingOnIt,
                TaskDueDate = new DateTime(2024, 02, 28),
                TaskPriority = Priority.Critical,
                LastUpdate = new DateTime(2024, 02, 28)
            };
            Task task3 = new Task()
            {
                TaskID = 3,
                TaskName = "Notification",
                ProjectLeadID = 101,
                ProjectLeadName = "Murugan",
                StatusOfTask = Status.Done,
                TaskDueDate = new DateTime(2024, 02, 28),
                TaskPriority = Priority.Critical,
                LastUpdate = new DateTime(2024, 02, 27)
            };
            TaskCollection.Add(task1);
            TaskCollection.Add(task2);
            TaskCollection.Add(task3);

            Project P = new Project()
            {
                ProjectID = 1001,
                ProjectName = "MatLab MiniDrone",
                StartDate = new DateTime(2024, 01, 12),
                LastDate = new DateTime(2024, 02, 28),
                SubmittedProjectCollection = TaskCollection
            };
            ProjectCollection.Add(P);
        }

        private static void AssignProject1()
        {
            TaskCollection = new List<Task>();
            Task task1 = new Task()
            {
                TaskID = 1,
                TaskName = "Close Button",
                ProjectLeadID = 101,
                ProjectLeadName = "Murugan",
                StatusOfTask = Status.Done,
                TaskDueDate = new DateTime(2024, 03, 02),
                TaskPriority = Priority.Low,
                LastUpdate = new DateTime(2024, 03, 01),
                SubmittedTaskCollection = new List<string>()
                {
                    "Created",
                    "Updated"
                }
            };
            Task task2 = new Task()
            {
                TaskID = 2,
                TaskName = "Animation Loader",
                ProjectLeadID = 101,
                ProjectLeadName = "Dhadiyan",
                StatusOfTask = Status.WorkingOnIt,
                TaskDueDate = new DateTime(2024, 02, 28),
                TaskPriority = Priority.Critical,
                LastUpdate = new DateTime(2024, 02, 28)
            };
            Task task3 = new Task()
            {
                TaskID = 3,
                TaskName = "Notification",
                ProjectLeadID = 101,
                ProjectLeadName = "Murugan",
                StatusOfTask = Status.Done,
                TaskDueDate = new DateTime(2024, 02, 28),
                TaskPriority = Priority.Critical,
                LastUpdate = new DateTime(2024, 02, 27)
            };
            Task task4 = new Task()
            {
                TaskID = 2,
                TaskName = "Animation Loader",
                ProjectLeadID = 101,
                ProjectLeadName = "Dhadiyan",
                StatusOfTask = Status.NotStarted,
                TaskDueDate = new DateTime(2024, 02, 28),
                TaskPriority = Priority.Medium,
                LastUpdate = new DateTime(2024, 02, 28)
            };
            Task task5 = new Task()
            {
                TaskID = 3,
                TaskName = "Notification",
                ProjectLeadID = 101,
                ProjectLeadName = "Murugan",
                StatusOfTask = Status.Stuck,
                TaskDueDate = new DateTime(2024, 02, 28),
                TaskPriority = Priority.High,
                LastUpdate = new DateTime(2024, 02, 27)
            };
            TaskCollection.Add(task1);
            TaskCollection.Add(task2);
            TaskCollection.Add(task3);
            TaskCollection.Add(task4);
            TaskCollection.Add(task5);

            Project P = new Project()
            {
                ProjectID = 1001,
                ProjectName = "Expense Tracker",
                StartDate = new DateTime(2023, 11, 29),
                LastDate = new DateTime(2024, 01, 05),
                SubmittedProjectCollection = TaskCollection
            };
            ProjectCollection.Add(P);
        }

        static public List<Task> TaskCollection;
        static public List<Project> ProjectCollection = new List<Project>();

    }
}
