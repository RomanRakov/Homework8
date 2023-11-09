using System;
namespace exercise
{
    class Report
    {
        public string Text { get; set; }
        public DateTime ExecutionDate { get; set; }
        public string Executor { get; set; }
        public Report(string text, DateTime executionDate, string executor)
        {
            Text = text;
            ExecutionDate = executionDate;
            Executor = executor;
        }
    }
}
