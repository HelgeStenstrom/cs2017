using Assignment5.ContactFiles;

namespace Assignment5
{
    public class Customer
    {
        public Contact Contact { get;  }

        #region Properties for colums to display
        public string IdString => ID.ToString();
        public string Name => Contact.FirstName;
        public string Street => Contact.Address.StreetAddress;
        public string PostalAddres => Contact.Address.PostalAddres;
        public string Country => Contact.Address.CountryString;
        public string Phone => Contact.Phone.ToString();
        public string Email => Contact.Email.ToString();
        #endregion

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
