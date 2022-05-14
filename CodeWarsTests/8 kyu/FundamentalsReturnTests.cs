using CodeWars._8_kyu;
using NUnit.Framework;

namespace CodeWarsTests._8_kyu
{
    [TestFixture]
    public class FundamentalsReturnTests
    {
        [Test]
        public void BasicTestAddition()
        {
            Assert.AreEqual(12, FundamentalsReturn.Add(5, 7),
              "Addition for 5 added to 7 should be: 12");
        }

        [Test]
        public void BasicTestMultiplication()
        {
            Assert.AreEqual(10, FundamentalsReturn.Multiply(5, 2),
              "Multiplication for 5 multiplied by 2 should be: 10");
        }
    }
}
