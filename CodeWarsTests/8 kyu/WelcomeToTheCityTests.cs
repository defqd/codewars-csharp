using CodeWars._8_kyu;
using NUnit.Framework;

namespace CodeWarsTests._8_kyu
{
    [TestFixture]
    public class WelcomeToTheCityTests
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual("Hello, John Smith! Welcome to Phoenix, Arizona!", WelcomeToTheCity.SayHello(new string[] { "John", "Smith" }, "Phoenix", "Arizona"));
            Assert.AreEqual("Hello, Wallace Russel Osbourne! Welcome to Albany, New York!", WelcomeToTheCity.SayHello(new string[] { "Wallace", "Russel", "Osbourne" }, "Albany", "New York"));
        }
    }
}
