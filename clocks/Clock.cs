using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WorldClock
{ 
    public class Clock
    {
        private string city;
        public void WhatIsTheTime()
        {
            ReadAndSaveCityName();
            ShowDateAndTime();
        }
        private void ReadAndSaveCityName()
        {
            Console.Clear();
            Console.WriteLine("Hi, what is the name of the city?");
            city = Console.ReadLine();
        }
        private void ShowDateAndTime()
        {
            Console.WriteLine("---------");
            Console.WriteLine("The date in " + city + ": " + DateTime.Now.ToLongDateString());
            Console.WriteLine("The time in " + city + ": " + DateTime.Now.ToLongTimeString());

        }
    }
}
