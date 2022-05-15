using CodeWars._8_kyu;
using NUnit.Framework;

namespace CodeWarsTests._8_kyu
{
    [TestFixture]
    public class BinToDecimalTests
    {
        [Test]
        public void MyTest()
        {
            Assert.AreEqual(0, BinToDecimal.binToDec("0"));
            Assert.AreEqual(1, BinToDecimal.binToDec("1"));
            Assert.AreEqual(2, BinToDecimal.binToDec("10"));
            Assert.AreEqual(3, BinToDecimal.binToDec("11"));
            Assert.AreEqual(6, BinToDecimal.binToDec("110"));
        }
    }
}
