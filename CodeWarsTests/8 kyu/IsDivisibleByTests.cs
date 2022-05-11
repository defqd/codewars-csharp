using NUnit.Framework;
using CodeWars._8_kyu;

namespace CodeWarsTests._8_kyu
{
    [TestFixture]
    public class IsDivisibleByTests
    {

        [Test]
        public void Test1()
        {
            Assert.AreEqual(true, IsDivisibleBy.isDivisible(12, 4, 3));
        }
        [Test]
        public void Test2()
        {
            Assert.AreEqual(false, IsDivisibleBy.isDivisible(3, 3, 4));
        }
        [Test]
        public void Test3()
        {
            Assert.AreEqual(false, IsDivisibleBy.isDivisible(8, 3, 4));
        }

    }
}
