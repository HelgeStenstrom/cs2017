// Helge Stenström 2017
// ah7875

using System.Collections.Generic;

namespace Assignment6
{
    /// <summary>
    /// The task manager works like a list of tasks, but with some encapsulation.
    /// Methods mimic the like-named methods of List<>
    /// </summary>
    public class TaskManager 
    {
        /// <summary>
        /// The list of tasks, empty to begin with.
        /// </summary>
        List<Task> _tasks = new List<Task>();

        /// <summary>
        /// Add a task to the list
        /// </summary>
        /// <param name="t"></param>
        public void Add(Task t)
        {
            _tasks.Add(t);
        }

        /// <summary>
        /// Clear the list, i.e., make it empty.
        /// </summary>
        internal void Clear()
        {
            _tasks.Clear();
        }

        /// <summary>
        /// Remove a task from the list.
        /// If the index is not valid, an exception will be thrown.
        /// </summary>
        /// <param name="index"></param>
        internal void RemoveAt(int index)
        {
            _tasks.RemoveAt(index);
        }

        /// <summary>
        /// Tasks can be accessed using index notation, just like lists and arrays.
        /// If the 
        /// </summary>indes is invalid, an exception will be thrown.
        /// <param name="index"></param>
        /// <returns></returns>
        internal Task this[int index]
        {
            get => _tasks[index];
            set => _tasks[index] = new Task(value);
        }

        /// <summary>
        /// Return a list of arrays of string.
        /// Each item in the list is a task
        /// Each item in the array is an aspect of the task, used to fill a column of a ListView.
        /// </summary>
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
