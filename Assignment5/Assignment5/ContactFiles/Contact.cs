// Helge Stenström 2017
// ah7875

using System;

namespace Assignment5.ContactFiles
{
    public class Contact
    {
        #region Constructors

        /// <summary>
        /// all-parameter constructor.
        /// Tests are made that none of the parameters is null.
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="address"></param>
        /// <param name="phone"></param>
        /// <param name="email"></param>
        public Contact(string firstName, string lastName, Address address, Phone phone, Email email)
        {
            Address = address ?? throw new ArgumentNullException(nameof(address));
            Email = email ?? throw new ArgumentNullException(nameof(email));
            FirstName = firstName ?? throw new ArgumentNullException(nameof(firstName));
            LastName = lastName ?? throw new ArgumentNullException(nameof(lastName));
            Phone = phone ?? throw new ArgumentNullException(nameof(phone));          
        }

        /// <summary>
        /// Copy constructor.
        /// </summary>
        /// <param name="other"></param>
        public Contact(Contact other)
        {
            this.FirstName = other.FirstName;
            this.LastName = other.LastName;
            this.Address = new Address(other.Address);
            this.Email = new Email(other.Email);
            this.Phone = new Phone(other.Phone);
        }

        /// <summary>
        /// A deep clone can be seen as an alternative to the copy constructor.
        /// </summary>
        /// <returns></returns>
        internal Contact DeepClone()
        {
            Contact c = new Contact(this.FirstName,
                this.LastName,
                new Address(this.Address),
                new Phone(this.Phone),
                new Email(this.Email));
            return c;
        }

        /// <summary>
        /// Default constructor, using default values.
        /// </summary>
        public Contact() :
            this(string.Empty, string.Empty, new Address(), new Phone(), new Email())
        {
        }
        #endregion
        
        #region Properties
        public Address Address { get; set; }
        public Email Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Phone Phone { get; set; }
        public string FullName => $"{FirstName} {LastName}";
        public string RevFullName => $"{LastName}, {FirstName}"; 
        #endregion
      
        /// <summary>
        /// String representation of a Contact.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{FullName} {Address} {Phone} {Email}";
        }

        /// <summary>
        /// Calling this method is like reading the IsValid property.
        /// I returns True if the contact is valid, i.e., it has a name, city and valid country.
        /// </summary>
        /// <returns></returns>
        public bool CheckData()
        {
            return IsValid;
        }

        /// <summary>
        /// True if the contact is valid, i.e., it has a name, city and valid country.
        /// </summary>
        public bool IsValid
        {
            get
            {
                bool hasName = !(string.IsNullOrWhiteSpace(FirstName) && string.IsNullOrWhiteSpace(LastName));
                bool hasCity = !(string.IsNullOrWhiteSpace(Address.City));
                bool hasCountry = Address.Country != Countries.Invalid_Country;
                return (hasName && hasCity && hasCountry);
            }
        }
    }
}
