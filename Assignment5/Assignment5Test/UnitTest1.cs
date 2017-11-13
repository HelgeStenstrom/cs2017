using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assignment5;

namespace Assignment5Test
{
    [TestClass]
    public class AddressTests
    {
        [TestMethod]
        public void ToString_forDefaultConstructor()
        {
            Address address = new Address();
            StringAssert.Contains(address.ToString(), "Sverige");
            Assert.AreEqual($"{"Sverige", 53}", address.ToString());
        }

        [TestMethod]
        public void ToString_allFields()
        {
            Address address = new Address("street", "zip", "city", Countries.Sverige);
            Assert.AreEqual($"{"street", -25} {"zip", -8} {"city", -10} {"Sverige"}", address.ToString());
        }

        [TestMethod]
        public void ToString_USA()
        {
            Address address = new Address("", "", "", Countries.United_States_of_America);
            StringAssert.Contains(address.ToString(), "United States of America");
        }


    }
}
