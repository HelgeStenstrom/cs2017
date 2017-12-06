using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    public class TaskManager 
    {
        List<Task> _tasks = new List<Task>();

        public void Add(Task t)
        {
            _tasks.Add(t);
        }

        internal void Clear()
        {
            _tasks.Clear();
        }

        internal void RemoveAt(int index)
        {
            _tasks.RemoveAt(index);
        }


        internal Task this[int index]
        {
            get => _tasks[index];
            set => _tasks[index] = new Task(value);
        }

        internal List<string[]> TasksAsStrings
        {
            get
            {
                List<string[]> taskStringList = new List<string[]>();
                foreach (Task task in _tasks)
                {
                    taskStringList.Add(task.RowStrings);
                }
                return taskStringList;
            }
        }
    }
}
