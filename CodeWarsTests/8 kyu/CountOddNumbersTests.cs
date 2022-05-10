using NUnit.Framework;
using CodeWars._8_kyu;

namespace CodeWarsTests._8_kyu
{
    [TestFixture]
    public class CountOddNumbersTests
    {
        [Test]
        public void Test()
        {
            Assert.AreEqual(7, CountOddNumbers.OddCount(15));
            Assert.AreEqual(7511, CountOddNumbers.OddCount(15023));
        }
    }
}

