using CodeWars._8_kyu;
using NUnit.Framework;

namespace CodeWarsTests._8_kyu
{
    [TestFixture]
    public class ParseIntFromCharTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual(3, ParseIntFromChar.GetAge("3 years old"));
            Assert.AreEqual(4, ParseIntFromChar.GetAge("4 years old"));
            Assert.AreEqual(9, ParseIntFromChar.GetAge("9 years old"));
        }
    }
}
