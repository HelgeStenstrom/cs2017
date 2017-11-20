// Helge Stenström 2017
// ah7875

using System;

namespace Assignment5.ContactFiles
{
    public class Contact
    {
        #region Constructors
        public Contact(string firstName, string lastName, Address address, Phone phone, Email email)
        {
            Address = address ?? throw new ArgumentNullException(nameof(address));
            Email = email ?? throw new ArgumentNullException(nameof(email));
            FirstName = firstName ?? throw new ArgumentNullException(nameof(firstName));
            LastName = lastName ?? throw new ArgumentNullException(nameof(lastName));
            Phone = phone ?? throw new ArgumentNullException(nameof(phone));          
        }

        internal Contact DeepClone()
        {
            Contact c = new Contact(this.FirstName,
                this.LastName,
                new Address(this.Address),
                new Phone(this.Phone),
                new Email(this.Email));
            return c;
        }

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
      
        public override string ToString()
        {
            return $"{FullName} {Address} {Phone} {Email}";
            throw new NotImplementedException();
        }

        public bool CheckData()
        {
            return IsValid;
        }

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