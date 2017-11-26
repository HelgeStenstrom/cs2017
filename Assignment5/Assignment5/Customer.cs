// Helge Stenström 2017
// ah7875

using Assignment5.ContactFiles;

namespace Assignment5
{
    /// <summary>
    /// A Customer is a Contact with a customer ID.
    /// ID functionality is not implemented here.
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// Return the contact of a Customer.
        /// </summary>
        public Contact Contact { get;  }

        #region Properties for colums to display
        // These properties are used to fill cells in a table.
        public string IdString => Id.ToString();
        public string Name => Contact.FirstName;
        public string Street => Contact.Address.StreetAddress;
        public string PostalAddres => Contact.Address.PostalAddress;
        public string Country => Contact.Address.CountryString;
        public string Phone => Contact.Phone.ToString();
        public string Email => Contact.Email.ToString();
        #endregion

        /// <summary>
        /// Return the ID of a customer
        /// </summary>
        public int Id { get; }

        /// <summary>
        /// Constructor with mandatory Contact and Id parameters.
        /// There is no default constructor.
        /// </summary>
        /// <param name="contact"></param>
        /// <param name="id"></param>
        public Customer(Contact contact, int id)
        {
            Id = id;
            Contact = contact;
        }

        /// <summary>
        /// String representation of the customer.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{Id} {Contact}";
        }
    }
}
