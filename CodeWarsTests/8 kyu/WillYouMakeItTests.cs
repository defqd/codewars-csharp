using CodeWars._8_kyu;
using NUnit.Framework;

namespace CodeWarsTests._8_kyu
{
    [TestFixture]
    public class WillYouMakeItTests
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual(true, WillYouMakeIt.ZeroFuel(50, 25, 2));
            Assert.AreEqual(false, WillYouMakeIt.ZeroFuel(100, 50, 1));
        }
    }
}
