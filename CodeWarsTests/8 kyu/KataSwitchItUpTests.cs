using CodeWars._8_kyu;
using NUnit.Framework;

namespace CodeWarsTests._8_kyu
{
    [TestFixture]
    public class KataSwitchItUpTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual("One", KataSwitchItUp.SwitchItUp(1));
            Assert.AreEqual("Three", KataSwitchItUp.SwitchItUp(3));
            Assert.AreEqual("Five", KataSwitchItUp.SwitchItUp(5));
        }
    }
}
