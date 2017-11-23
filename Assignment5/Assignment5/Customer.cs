using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment5.ContactFiles;

namespace Assignment5
{
    public class Customer
    {
        public Contact Contact { get => _contact; set => _contact = value; }
        public int ID { get => _id; set => _id = value; }

        Contact _contact;
        int _id;

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
