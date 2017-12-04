﻿using System;
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
    }
}