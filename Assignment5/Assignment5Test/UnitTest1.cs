using Assignment5.ContactFiles;
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
            Assert.AreEqual($"{"Sverige", 53}", address.ToString());
        }

        [TestMethod]
        public void ToString_allFields()
        {
            var address = new Address("street", "zip", "city", Countries.Sverige);
            Assert.AreEqual($"{"street",-25} {"zip",-8} {"city",-10} Sverige", address.ToString());
        }

        [TestMethod]
        public void ToString_USA()
        {
            var address = new Address("", "", "", Countries.United_States_of_America);
            StringAssert.Contains(address.ToString(), "United States of America");
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
}
