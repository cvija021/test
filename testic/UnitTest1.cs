using NUnit.Framework;

namespace testic
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            System.Console.WriteLine("Hello World");
            Assert.Pass();
        }
    }
}