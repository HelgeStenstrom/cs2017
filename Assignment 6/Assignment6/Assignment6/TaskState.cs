using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment6
{
    /// <summary>
    /// This enum provides a way of expressing the state of a task.
    /// Since it only has two values, it's simpler to use a boolean.
    /// </summary>
    public enum TaskState
    {
        Done,
        NotDone
    }
}