using NUnit.Framework;

namespace MySolution.Tests
{
    [TestFixture]
    public class PersonTests
    {
        [Test]
        public void GetFullName_ReturnsCorrectFullName()
        {
            
            Person person = new Person("John", "Doe");

            
            string fullName = person.GetFullName();

            
            Assert.AreEqual("John Doe", fullName);
        }
    }
}