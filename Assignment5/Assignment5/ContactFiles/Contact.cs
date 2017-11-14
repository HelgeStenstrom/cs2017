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

        public Contact()
        {
            // TODO: Testa att denna constructor ger en Contact med efternamnet "efternamn".
            new Contact(string.Empty, "efternamn", new Address(), new Phone(), new Email());
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
            throw new NotImplementedException();
        }
    }
}