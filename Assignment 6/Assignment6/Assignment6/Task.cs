using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    public class Task
    {
        public Task(string description, Priority priority, DateTime date, bool isDone)
        {
            Description = description ?? throw new ArgumentNullException(nameof(description));
            Priority = priority;
            Date = date;
            IsDone = isDone;
        }

        public  DateTime Date { get; set; }
        public bool IsDone { get; set; }
        public TaskState TaskState { get; set; }
        public string Description { get; set; }

        public Priority Priority { get; set; }
        public string PrioString { get => Priority.ToString().Replace('_', ' '); }

        public override string ToString()
        {
            return $"{Date, -20}{Priority, -10}{Description, -30}";
        }
    }
}
