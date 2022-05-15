using CodeWars._5_kyu;
using NUnit.Framework;

namespace CodeWarsTests._5_kyu
{
    [TestFixture]
    public class NumberOfTrailingZerosOfNTests
    {
        [TestFixture]
        public class TrailingZeros
        {
            [Test]
            public void BasicTests()
            {
                Assert.AreEqual(1, NumberOfTrailingZerosOfN.TrailingZeros(5));
                Assert.AreEqual(6, NumberOfTrailingZerosOfN.TrailingZeros(25));
                Assert.AreEqual(131, NumberOfTrailingZerosOfN.TrailingZeros(531));
            }
        }
    }
}
