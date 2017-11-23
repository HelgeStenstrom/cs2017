using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment5.ContactFiles;

namespace Assignment5
{
    public class CustomerManager
    {
        private List<Customer> _customers;
        private IdFactory idFactory = new IdFactory();

        public int Count => _customers.Count;
        public List<Customer> Customers => _customers;

        public CustomerManager()
        {
            _customers = new List<Customer>(); // Initially empty.
        }

        public void AddCustomer(Customer customer)
        {
            _customers.Add(customer);
        }

        public void AddCustomer(Contact contact)
        {
            _customers.Add(new Customer(contact, idFactory.getNextID()));
        }

        public Customer GetCustomer(int index)
        {
            return _customers[index];
        }

        public bool DeleteCustomer(int index)
        {
            if (index >= Count)
                return false;
            _customers.RemoveAt(index);
            return true;
        }

        public bool ChangeCustomer(Contact contact, int index)
        {
            if (index >= Count)
                return false;
            _customers[index] = new Customer(contact, idFactory.getNextID());
            return true;
        }

        public bool ChangeCustomer(Customer customer, int index)
        {
            if (index >= Count)
                return false;
            _customers[index] = customer;
            return true;

        }

        public string[] GetCustomerInfo()
        {
            throw new NotImplementedException();
        }
        
        
    }
}
