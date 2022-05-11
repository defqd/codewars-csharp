using CodeWars._8_kyu;
using NUnit.Framework;
using System;

namespace CodeWarsTests._8_kyu
{
    [TestFixture]
    public class SumOfMultiplesTests
    {
        [Test, Description("Should produce expected results for valid inputs")]
        public void SampleTest()
        {
            Assert.AreEqual(20, SumOfMultiples.SumMul(2, 9), "n = 2, m = 9");
            Assert.AreEqual(30, SumOfMultiples.SumMul(5, 20), "n = 5, m = 20");
            Assert.AreEqual(1860, SumOfMultiples.SumMul(4, 123), "n = 4, m = 123");
            Assert.AreEqual(86469, SumOfMultiples.SumMul(123, 4567), "n = 123, m = 4567");
        }

        [Test, Description("Should throw for invalid inputs")]
        public void ErrorTest()
        {
            Assert.Throws<ArgumentException>(() => SumOfMultiples.SumMul(4, 1), "n = 4, m = 1");
            Assert.Throws<ArgumentException>(() => SumOfMultiples.SumMul(0, 20), "n = 0, m = 20");
        }
    }
}
