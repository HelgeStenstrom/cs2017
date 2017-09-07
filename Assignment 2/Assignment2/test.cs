using NUnit.Framework;

// Compile with:
// csc MainProgram.cs Input.cs testMainProgram.cs -reference:/Users/helge/hack/NUnit.Framework-3.8.0/bin/net-4.5/nunit.framework.dll 


// using MainProgram;
namespace Assignment2
{
	[TestFixture]
	public class SomeTests
	{
		[SetUp]
		protected void SetUp()
		{
			// Nothing yet.
		}

		[Test]
		public void dummyTest()
		{
			System.Console.WriteLine("Dummy test ");
		}

	 	[Test]
        public void willPass()
        {
            Assert.AreEqual(2, 2);
        }

        [Test]
        public void willFail()
        {
            Assert.AreEqual(1, 2);
        }
	}
}
