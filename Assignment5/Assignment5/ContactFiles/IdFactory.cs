﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5.ContactFiles
{
    public class IdFactory
    {
        private int nextID = 100;

        public int getNextID()
        {
            return nextID++;
        }
    }
}