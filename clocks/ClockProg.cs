using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WorldClock
{
    class ClockProg
    {
        static void Main(string [] args)
        {
            Clock clockObj = new Clock();
            clockObj.WhatIsTheTime();
            Console.ReadLine();
        }
    }
}
