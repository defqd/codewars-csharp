using CodeWars._8_kyu;
using NUnit.Framework;

namespace CodeWarsTests._8_kyu
{
    [TestFixture]
    public class ConvertAStringToANumberTests
    {
        [Test]
        public void test1()
        {
            Assert.AreEqual(1234, ConvertAStringToANumber.StringToNumber("1234"));
        }

        [Test]
        public void test2()
        {
            Assert.AreEqual(605, ConvertAStringToANumber.StringToNumber("605"));
        }

        [Test]
        public void test3()
        {
            Assert.AreEqual(1405, ConvertAStringToANumber.StringToNumber("1405"));
        }

        [Test]
        public void test4()
        {
            Assert.AreEqual(-7, ConvertAStringToANumber.StringToNumber("-7"));
        }
    }
}
