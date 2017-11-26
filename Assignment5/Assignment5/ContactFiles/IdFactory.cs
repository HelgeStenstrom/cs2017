// Helge Stenström 2017
// ah7875

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5.ContactFiles
{
    /// <summary>
    /// Generates ID numbers, starting at 100. 
    /// </summary>
    public class IdFactory
    {
        private int nextID = 100;

        /// <summary>
        /// Each call returns a new unique ID number.
        /// </summary>
        /// <returns></returns>
        public int getNextID()
        {
            return nextID++;
        }
    }
}
