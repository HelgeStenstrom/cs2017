// Helge Stenström 2017
// ah7875

using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment5.ContactFiles
{
    public class Address
    {
        public string StreetAddress { get; set; }
        public string Zip {
            get;
            set; }
        public string City { get; set; }
        public Countries Country { get; set; }

        public string PostalAddres => $"{Zip} {City}";

        public Address(string street, string zip, string city, Countries country)
        {
            StreetAddress = street;
            Zip = zip;
            City = city;
            Country = country;
        }
        
        public Address(string street, string zip, string city):
                         this(street,        zip,        city, Countries.Sverige)
        {
        }

        /// <summary>
        /// Default constructor
        /// </summary>
        public Address():
            this(string.Empty, string.Empty, string.Empty, Countries.Sverige)
        {
        }

        public Address(Address theOther)
        {
            StreetAddress = theOther.StreetAddress;
            Zip = theOther.Zip;
            City = theOther.City;
            Country = theOther.Country;
        }

        public string GetCountryString()
        {
            return Country.ToString().Replace("_", " ");
        }


        public static List<string> GetAllCountryStrings()
        {
            List<string> countries = new List<string>();
            foreach (string country in Enum.GetNames(typeof(Countries)))
            {
                countries.Add(country.Replace("_", " "));
            }
            return countries;
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
            return $"{StreetAddress, -25} {Zip, -8} {City, -10} {GetCountryString(), -20}";
        }
    }
}