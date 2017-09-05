using NUnit.Framework;
using System;

namespace PetApplication
{
    [TestFixture]
    public class PetsTests
    {
        private Pet p;

        static void Main(string [] args)
        {
            Console.WriteLine("Hej!");
        }

        [SetUp]
        protected void SetUp()
        {
            p = new Pet();
        }

        [Test]
        public void aTest()
        {
            var x = 3.13;
        }

        [Test]
        public void failingTest()
        {
            Assert.AreEqual(3,4);
        }

        [Test]
        public void weHaveAPet()
        {
            Assert.AreEqual("intersex", p.gender());
        }

    }
}
