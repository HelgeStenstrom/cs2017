// Helge Stenström 2017
// ah7875

using System;
using System.Collections.Generic;

namespace Assignment6
{
    /// <summary>
    /// Data container for a task, more or less.
    /// </summary>
    public class Task
    {
        /// <summary>
        /// Full constructor
        /// </summary>
        /// <param name="description"></param>
        /// <param name="priority"></param>
        /// <param name="date"></param>
        /// <param name="isDone"></param>
        public Task(string description, Priority priority, DateTime date, bool isDone)
        {
            Description = description ?? throw new ArgumentNullException(nameof(description));
            Priority = priority;
            Date = date;
            IsDone = isDone;
        }

        /// <summary>
        /// Copy constructor.
        /// </summary>
        public Task(Task old)
        {
            Description = old.Description;
            Priority = old.Priority;
            Date = old.Date;
            IsDone = old.IsDone;
        }

        public  DateTime Date { get; }
        public bool IsDone { get; }
        public TaskState TaskState { get; set; }
        public string Description { get; }

        public Priority Priority { get; set; }
        public string PrioString => Priority.ToString().Replace('_', ' ');

        /// <summary>
        /// String representation of a task.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{Date, -20}{Priority, -10}{Description, -30}";
        }

        /// <summary>
        /// String representations of all defined priorities, to be used in a cyclic field.
        /// </summary>
        public static List<string> GetAllPrioStrings()
        {
            List<string> prios = new List<string>();
            foreach (string prio in Enum.GetNames(typeof(Priority)))
            {
                prios.Add(prio.Replace("_", " "));
            }
            return prios;
        }

        /// <summary>
        /// Strings representing a row in a ListView.
        /// </summary>
        /// <returns></returns>
        public string[] RowStrings => new[]
                    {
                    Date.ToShortDateString(),
                    $"{Date.Hour.ToString()}:{Date.Minute.ToString()}",
                    PrioString,
                    IsDone.ToString(),
                    Description
                    };
    }
}
