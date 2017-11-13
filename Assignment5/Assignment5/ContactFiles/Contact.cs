using System;

namespace Assignment5.ContactFiles
{
    public class Contact
    {
        #region Properties
        public Address Address { get; set; }
        public Email Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Phone Phone { get; set; }
        public string FullName => $"put full name here";
        #endregion


        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}