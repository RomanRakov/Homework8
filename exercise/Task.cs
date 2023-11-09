using System;
using System.Collections.Generic;
namespace exercise
{
    class Task
    {
        public string Description { get; set; }
        public DateTime Deadline { get; set; }
        public string Initiator { get; set; }
        public string Assignee { get; set; }
        public TaskStatus Status { get; set; }
        public List<Report> Reports { get; set; }
        public Task(string description, DateTime deadline, string initiator, string assignee)
        {
            Description = description;
            Deadline = deadline;
            Initiator = initiator;
            Assignee = assignee;
            Status = TaskStatus.Назначена;
            Reports = new List<Report>();
        }
    }
}
