﻿// Helge Stenström
// ah7875

using Assignment5.ContactFiles;
using Assignment5;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Assignment5Test
{
    [TestClass]
    public class AddressTests
    {
        [TestMethod]
        public void ToString_forDefaultConstructor()
        {
            var address = new Address();
            StringAssert.Contains(address.ToString(), "Sverige");
            // Assert.AreEqual($"{"Sverige", 53}", address.ToString());
        }

        [TestMethod]
        public void ToString_allFields()
        {
            var address = new Address("street", "zip", "city", Countries.Sverige);
            Assert.AreEqual($"{"street",-25} {"zip",-8} {"city",-10} {"Sverige", -20}", address.ToString());
        }

        [TestMethod]
        public void ToString_USA()
        {
            var address = new Address("", "", "", Countries.United_States_of_America);
            StringAssert.Contains(address.ToString(), "United States of America");
        }

        [TestMethod]
        public void constructWith3arguments()
        {
            var address = new Address("street", "zip", "city");
            Assert.AreEqual("street", address.Street);
            Assert.AreEqual("zip", address.Zip);
            Assert.AreEqual("city", address.City);
            Assert.AreEqual(Countries.Sverige, address.Country);
        }
    }

    [TestClass]
    public class EmailTests
    {
        [TestMethod]
        public void createEmail()
        {
            var email = new Email();            
        }

        [TestMethod]
        public void createEmail_workMail()
        {
            var email = new Email("me@work.se");
        }

        [TestMethod]
        public void createEmail_work_homeMail()
        {
            var email = new Email("me@work.se", "me@home.se");
            Assert.AreEqual("me@work.se           me@home.se          ", email.ToString());
        }


    }


    [TestClass]
    public class IdFactoryTests
    {
        [TestMethod]
        public void idsAreConsecutive()
        {
            IdFactory IdFactory = new IdFactory();
            Assert.AreEqual(100, IdFactory.getNextID());
            Assert.AreEqual(101, IdFactory.getNextID());
            Assert.AreEqual(102, IdFactory.getNextID());
        }

        
    }

    [TestClass]
    public class ContactTests
    {
        Contact ValidContact()
        {
            Contact c = new Contact("first", "last", 
                new Address("", "", "city", Countries.Andorra),
                new Phone(),
                new Email());
            return c;
        }

        [TestMethod]
        public void createAContact()
        {
            Contact c = new Contact();
            Assert.AreEqual("", c.LastName);
        }

        [TestMethod]
        public void TestValidContact()
        {
            var c = ValidContact();
            Assert.IsTrue(c.IsValid);
        }

        [TestMethod]
        public void NotValidWhen_NameMissing()
        {
            var c = ValidContact();
            c.FirstName = "";
            c.LastName = "";
            Assert.IsFalse(c.IsValid);
        }

        [TestMethod]
        public void NotValidWhen_CityMissing()
        {
            var c = ValidContact();
            c.Address.City = "";
            Assert.IsFalse(c.IsValid);
        }

        [TestMethod]
        public void NotValidWhen_CountryMissing()
        {
            var c = ValidContact();
            c.Address.Country = Countries.Invalid_Country;
            Assert.IsFalse(c.IsValid);
        }




    }

    [TestClass, Ignore]
    public class ContactFormTests
    {
        [TestMethod]
        public void CreateForm()
        {
            Contact c = new Contact("First", "Last", 
                new Address("Gatan", "zip", "Staden", Countries.Andorra),
                new Phone("home", "work"), 
                new Email("e-work", "e-pers"));

            ContactForm contactForm = new ContactForm(c);
            Assert.AreEqual("Last", contactForm.TxtLastName.Text);
        }
    }

    [TestClass]
    public class CustomerTests
    {
        [TestMethod]
        public void hasId_andCoutnry()
        {
            Contact c = new Contact();
            Customer customer = new Customer(c, 17);
            StringAssert.StartsWith(customer.ToString(), "17");
            StringAssert.Contains(customer.ToString(), "Sverige");
        }
    }

    [TestClass]
    public class CustomManagerTests
    {
        [TestMethod]
        public void test1()
        {

        }
    }

}
