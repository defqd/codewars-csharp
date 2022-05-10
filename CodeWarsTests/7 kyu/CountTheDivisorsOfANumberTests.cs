using CodeWars._7_kyu;
using NUnit.Framework;

namespace CodeWarsTests._7_kyu
{
    [TestFixture]
    public class CountTheDivisorsOfANumberTests
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual(1, CountTheDivisorsOfANumber.Divisors(1));
            Assert.AreEqual(4, CountTheDivisorsOfANumber.Divisors(10));
            Assert.AreEqual(2, CountTheDivisorsOfANumber.Divisors(11));
            Assert.AreEqual(8, CountTheDivisorsOfANumber.Divisors(54));
        }
    }
}
