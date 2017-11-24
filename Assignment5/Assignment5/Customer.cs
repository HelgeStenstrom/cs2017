﻿using Assignment5.ContactFiles;

namespace Assignment5
{
    public class Customer
    {
        public Contact Contact { get;  }

        public int ID { get; }

        public Customer(Contact contact, int id)
        {
            ID = id;
            Contact = contact;
        }

        public override string ToString()
        {
            return $"{ID} {Contact}";
        }
    }
}