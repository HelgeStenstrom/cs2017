﻿// Helge Stenström 2017
// ah7875

using System;

namespace Assignment5.ContactFiles
{
    public class Address
    {
        public string Street { get; set; }
        public string Zip { get; set; }
        public string City { get; set; }
        public Countries Country { get; set; }

        public Address(string street, string zip, string city, Countries country)
        {
            Street = street;
            Zip = zip;
            City = city;
            Country = country;
        }
        
        public Address(string street, string zip, string city):
            this(street, zip, city, Countries.Sverige)
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
            Street = theOther.Street;
            Zip = theOther.Zip;
            City = theOther.City;
            Country = theOther.Country;
        }

        public string GetCountryString()
        {
            return Country.ToString().Replace("_", " ");
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
            return $"{Street, -25} {Zip, -8} {City, -10} {GetCountryString()}";
        }
    }
}