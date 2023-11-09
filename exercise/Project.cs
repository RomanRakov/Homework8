using System;
using System.Collections.Generic;
namespace exercise
{
    class Project
    {
        public string Description { get; set; }
        public DateTime Deadline { get; set; }
        public string Initiator { get; set; }
        public string TeamLead { get; set; }
        public List<Task> Tasks { get; set; }
        public ProjectStatus Status { get; set; }
        public Project(string description, DateTime deadline, string initiator, string teamLead)
        {
            Description = description;
            Deadline = deadline;
            Initiator = initiator;
            TeamLead = teamLead;
            Tasks = new List<Task>();
            Status = ProjectStatus.Проект;
        }
    }
}
