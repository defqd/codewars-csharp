using CodeWars._8_kyu;
using NUnit.Framework;

namespace CodeWarsTests._8_kyu
{
    [TestFixture]
    public class ReturnNegativeTests
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual(-42, ReturnNegative.MakeNegative(42));
        }
    }
}
