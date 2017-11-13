using System;
using System.Windows.Forms;

namespace CustomerRegistry.ContactFiles
{
    public class Address
    {
        private string _street;

        public string Street
        {
            get => _street;
            set => _street = value;
        }

        public string Zip
        {
            get => _zip;
            set => _zip = value;
        }

        public string City
        {
            get => _city;
            set => _city = value;
        }

        public Countries Country
        {
            get => _country;
            set => _country = value;
        }

        private string _zip;
        private string _city;
        private Countries _country;
        
        public Address(string street, string zip, string city, Countries country)
        {
            _street = street;
            _zip = zip;
            _city = city;
            _country = country;
        }
        
        public Address(string street, string zip, string city):
            this(street, zip, city, Countries.Sverige)
        {
        }

        /// <summary>
        /// Default constructor
        /// </summary>
        public Address()
        {
            _street = string.Empty;
            _zip = string.Empty;
            _city = string.Empty;
            _country = Countries.Sverige;
        }

        public Address(Address theOther)
        {
            throw new NotImplementedException();
        }

        public string GetCountryString()
        {
            return _country.ToString().Replace("_", " ");
        }

        public string GetAddressLabel()
        {
            throw new NotImplementedException();
        }

        public bool Validate()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"{_street, -25} {_zip, -8} {_city, -10} {GetCountryString()}";
        }
    }
}