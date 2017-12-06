// Helge Stenström 2017
// ah7875

using System;
using System.Collections.Generic;
using Assignment5.ContactFiles;

namespace Assignment5
{
    /// <summary>
    /// The CustomerMagagers handles a list of customers. 
    /// Customers can be added to and deleted from the list.
    /// Customers in the list can be changed.
    /// CustomerManager allocates IDs for the customers.
    /// </summary>
    public class CustomerManager
    {
        #region Instance variables
        /// <summary>
        /// The list of customers that the manager handles
        /// </summary>
        private readonly List<Customer> _customers;

        /// <summary>
        /// The maker of unique ID numbers.
        /// </summary>
        private readonly IdFactory _idFactory = new IdFactory();
        #endregion

        /// <summary>
        /// The number of customers that the manager currently has.
        /// </summary>
        public int Count => _customers.Count;

        /// <summary>
        /// The customer list, as a property.9
        /// </summary>
        private List<Customer> Customers => _customers;

        /// <summary>
        /// Data to fill a ListView, one customer per item in the list.
        /// </summary>
        public List<string[]> CustomersAsRows
        {
            get
            {
                List<string[]> l = new List<string[]>();
                foreach (Customer c in _customers)
                {
                    l.Add(c.RowStrings);
                }
                return l;
            }
        }

        /// <summary>
        /// Default constructor, creates a list to hold the customers.
        /// </summary>
        public CustomerManager()
        {
            _customers = new List<Customer>(); // Initially empty.
        }

        /// <summary>
        /// Add a customer to the list.
        /// </summary>
        /// <param name="customer"></param>
        public void AddCustomer(Customer customer)
        {
            _customers.Add(customer);
        }

        /// <summary>
        /// Add a customer, given a contact. 
        /// The customer is created from the contact plus a generated ID.
        /// </summary>
        /// <param name="contact"></param>
        public void AddCustomer(Contact contact)
        {
            _customers.Add(new Customer(contact, _idFactory.getNextID()));
        }

        /// <summary>
        /// Return the wanted customer by index in the list. 
        /// Will generate an exception when the index is outside the list.
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public Customer GetCustomer(int index)
        {
            return _customers[index];
        }

        /// <summary>
        /// Delete a customer by index.
        /// </summary>
        /// <param name="index"></param>
        /// <returns>True return value indicates success.</returns>
        public bool DeleteCustomer(int index)
        {
            if (index >= Count)
                return false;
            _customers.RemoveAt(index);
            return true;
        }

        /// <summary>
        /// Replace the indexed customer with a new one, 
        /// generated from the given contact plus a generated ID.
        /// </summary>
        /// <param name="contact"></param>
        /// <param name="index"></param>
        /// <returns>True return value indicates success.</returns>
        public bool ChangeCustomer(Contact contact, int index)
        {
            if (index >= Count)
                return false;
            _customers[index] = new Customer(contact, _idFactory.getNextID());
            return true;
        }

        /// <summary>
        /// Replace the indexed existing customer with the given one.
        /// </summary>
        /// <param name="customer"></param>
        /// <param name="index"></param>
        /// <returns>True return value indicates success.</returns>
        public bool ChangeCustomer(Customer customer, int index)
        {
            if (index >= Count)
                return false;
            _customers[index] = customer;
            return true;

        }
    }
}
