// Helge Stenström 2017
// ah7875

using System;
using System.Collections.Generic;

namespace Assignment5.ContactFiles
{
    public class Address
    {
        /// <summary>
        ///  Simple properties are used instead of instance variables.
        /// </summary>
        public string StreetAddress { get; set; }
        public string Zip {get; set; }
        public string City { get; set; }
        public Countries Country { get; set; }

        /// <summary>
        /// PostalAddres is postal number plus city.
        /// </summary>
        public string PostalAddress => $"{Zip} {City}";

        /// <summary>
        /// Constructor with largest numbers of parameters. Other constructors call this one.
        /// </summary>
        /// <param name="street"></param>
        /// <param name="zip"></param>
        /// <param name="city"></param>
        /// <param name="country"></param>
        public Address(string street, string zip, string city, Countries country)
        {
            StreetAddress = street;
            Zip = zip;
            City = city;
            Country = country;
        }
        
        /// <summary>
        /// Simplified constructor, using default value for Country.
        /// The called constructor could have an optional country argument.
        /// </summary>
        /// <param name="street"></param>
        /// <param name="zip"></param>
        /// <param name="city"></param>
        public Address(string street, string zip, string city):
                         this(street,        zip,        city, Countries.Invalid_Country)
        {
        }

        /// <summary>
        /// Default constructor with default values for everything. Rather useless.
        /// </summary>
        public Address():
            this(string.Empty, string.Empty, string.Empty, Countries.Invalid_Country)
        {
        }

        /// <summary>
        ///  Copy constructor.
        /// </summary>
        /// <param name="theOther"></param>
        public Address(Address theOther)
        {
            StreetAddress = theOther.StreetAddress;
            Zip = theOther.Zip;
            City = theOther.City;
            Country = theOther.Country;
        }

        /// <summary>
        /// String representation of the country, in a readable format.
        /// </summary>
        public string CountryString => Country.ToString().Replace("_", " ");


        /// <summary>
        /// String representations of all defined countries, to be used in a cyclic field.
        /// </summary>
        public static List<string> GetAllCountryStrings()
        {
            List<string> countries = new List<string>();
            foreach (string country in Enum.GetNames(typeof(Countries)))
            {
                countries.Add(country.Replace("_", " "));
            }
            return countries;
        }



        /// <summary>
        /// Intent was to return wether this address is valid or not. but I seen no need for this method.
        /// It would be a mistake to write unused code.
        /// We have validation of a Contact elsewhere.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public bool Validate()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// String representation of an address, with fixed width.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{StreetAddress, -25} {Zip, -8} {City, -10} {CountryString, -20}";
        }
    }
}