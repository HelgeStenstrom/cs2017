using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment5.ContactFiles;

namespace Assignment5
{
    class CustomerManager
    {
        List<Customer> _customers;

        public int Count => _customers.Count;

        CustomerManager()
        {
            _customers = new List<Customer>(); // Initially empty.
        }

        int GetCount()
        {
            return _customers.Count;
        }

        bool AddCustomer(Contact contact)
        {
            throw new NotImplementedException();
        }
        
        bool AddCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        bool ChangeCustomer(Contact contact, int index)
        {
            throw new NotImplementedException();
        }

        bool DeleteCustomer(int index)
        {
            throw new NotImplementedException();
        }

        Customer GetCustomer(int index)
        {
            throw new NotImplementedException();
        }

        string[] GetCustomerInfo()
        {
            throw new NotImplementedException();
        }
        
        
    }
}
