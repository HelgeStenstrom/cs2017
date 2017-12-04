using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    public class TaskManager: List<Task>
    {
        List<Task> _tasks = new List<Task>();

        public void Addx(Task t)
        {
            _tasks.Add(t);
        }
    }
}
