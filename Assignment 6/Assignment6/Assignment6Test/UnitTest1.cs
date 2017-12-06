// Helge Stenström 2017
// ah7875

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assignment6;

namespace Assignment6Test
{
    [TestClass]
    public class TaskTests
    {
        [TestMethod]
        public void CreateATask()
        {
            // Exercise
            Task t = new Task("", Priority.Important, DateTime.Now, false);
        }

        [TestMethod]
        public void PrioText()
        {
            // Setup
            Task t = new Task("", Priority.Important, DateTime.Now, false);
            t.Priority = Priority.Less_important;

            // Verify
            Assert.AreEqual("Less important", t.PrioString);
        }
    }

    [TestClass]
    public class TaskManagerTests
    {
        [TestMethod]
        public void AddSomeTasks()
        {
            // Set up
            TaskManager tm = new TaskManager();
            Task t = new Task("", Priority.Important, DateTime.Now, false);

            // Exercise
            tm.Add(t);
        }

        [TestMethod, Ignore] // Jag vet inte var jag vill med ToString
        public void TextOfManager()
        {
            // Set up
            TaskManager tm = new TaskManager();
            Task t = new Task("", Priority.Important, DateTime.Now, false);
            tm.Add(t);

            // Exercise && verify

            Assert.AreEqual("", tm.ToString());
        }
    }
}

