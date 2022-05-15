using CodeWars._8_kyu;
using NUnit.Framework;
using System.Collections.Generic;

namespace CodeWarsTests._8_kyu
{
    [TestFixture]
    public class FindMultiplesOfANumberTests
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual(new List<int> { 5, 10, 15, 20, 25 }, FindMultiplesOfANumber.FindMultiples(5, 25));
            Assert.AreEqual(new List<int> { 1, 2 }, FindMultiplesOfANumber.FindMultiples(1, 2));
        }
    }
}
