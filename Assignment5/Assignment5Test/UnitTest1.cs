// Helge Stenström 2017
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
            StringAssert.Contains(address.ToString(), "Invalid");
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
            Assert.AreEqual("street", address.StreetAddress);
            Assert.AreEqual("zip", address.Zip);
            Assert.AreEqual("city", address.City);
            Assert.AreEqual(Countries.Invalid_Country, address.Country);
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
            StringAssert.Contains(customer.ToString(), "Invalid");
        }
    }

    [TestClass]
    public class CustomerManagerTests
    {
        Contact contact;
        Customer customer;
        CustomerManager cm;

        [TestInitialize]
        public void setup()
        {
            contact = new Contact("First", "Last",
                new Address("Gatan", "123 45", "Sthlm"),
                new Phone("08-10000", "010-10000"),
                new Email("x@work.com","y@home.se"));

            customer = new Customer(contact, 17);
            cm = new CustomerManager();
        }

        [TestMethod]
        public void Adding_a_customer_increases_length()
        {
            Assert.AreEqual(0, cm.Count);
            cm.AddCustomer(customer);
            Assert.AreEqual(1, cm.Count);
        }

        [TestMethod]
        public void Add_contact()
        {
            cm.AddCustomer(contact);
            cm.AddCustomer(contact);
            Assert.AreEqual(2, cm.Count);
        }

        [TestMethod]
        public void get_a_customer()
        {
            // Setup
            var cu1 = new Customer(new Contact(), 1);
            var cu2 = new Customer(new Contact(), 2);
            var cu3 = new Customer(new Contact(), 3);
            cm.AddCustomer(cu1);
            cm.AddCustomer(cu2);
            cm.AddCustomer(cu3);

            // Exercise and verify
            Assert.AreSame(cu2, cm.GetCustomer(1));
            Assert.AreSame(cu3, cm.GetCustomer(2));
            Assert.AreSame(cu1, cm.GetCustomer(0));
        }

        [TestMethod]
        public void delete_a_customer()
        {
            // Setup
            var cu1 = new Customer(new Contact(), 1);
            var cu2 = new Customer(new Contact(), 2);
            var cu3 = new Customer(new Contact(), 3);
            cm.AddCustomer(cu1);
            cm.AddCustomer(cu2);
            cm.AddCustomer(cu3);
            // pre-check
            Assert.AreEqual(3, cm.Count);

            // Exercise
            bool result = cm.DeleteCustomer(1);

            // Verify
            Assert.IsTrue(result);
            Assert.AreEqual(2, cm.Count);
            Assert.AreSame(cu1, cm.GetCustomer(0));
            Assert.AreSame(cu3, cm.GetCustomer(1));
        }

        [TestMethod]
        public void delete_fail_bad_index()
        {
            int numberOfCustomers = 5;
            // Setup
            for (int i = 0; i<numberOfCustomers; i++)
               cm.AddCustomer(contact);
            // pre-check
            Assert.AreEqual(numberOfCustomers, cm.Count);
            // Exercise
            bool result = cm.DeleteCustomer(numberOfCustomers);

            // Verify
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void replacing_a_customer()
        {
            // Setup
            var cu1 = new Customer(new Contact(), 1);
            var cu2 = new Customer(new Contact(), 2);
            var cu3 = new Customer(new Contact(), 3);

            cm.AddCustomer(cu1);
            cm.AddCustomer(cu2);

            // Exercise: replace the customer at pos 1 (0 is the first)
            cm.ChangeCustomer(cu3, 1);

            // Verify
            Assert.AreSame(cu1, cm.GetCustomer(0));
            Assert.AreSame(cu3, cm.GetCustomer(1));
        }

        [TestMethod]
        public void replacing_a_contact()
        {
            // Setup
            var cu1 = new Customer(new Contact(), 1);
            var cu2 = new Customer(new Contact(), 2);
            var cu3 = new Customer(new Contact(), 3);

            cm.AddCustomer(cu1);
            cm.AddCustomer(cu2);
            cm.AddCustomer(cu3);

            // Exercise: replace the customer at pos 1 (0 is the first)
            cm.ChangeCustomer(contact, 1);

            // Verify
            Assert.AreSame(cu1, cm.GetCustomer(0));
            Assert.AreSame(cu3, cm.GetCustomer(2));
            // First generated customer ID is 100.
            var cust = cm.GetCustomer(1);
            Assert.AreEqual("Gatan", cust.Contact.Address.StreetAddress);
            Assert.AreEqual(100, cust.Id);




        }
    }
}
