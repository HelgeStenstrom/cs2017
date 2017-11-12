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
            Assert.AreEqual("Sverige", address.ToString());
        }

        [TestMethod]
        public void ToString_USA()
        {
            Address address = new Address("", "", "", Countries.United_States_of_America);
            StringAssert.Contains(address.ToString(), "United States of America");
        }


    }
}
