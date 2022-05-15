using CodeWars._8_kyu;
using NUnit.Framework;

namespace CodeWarsTests._8_kyu
{
    [TestFixture]
    public class OppositesAttractTests
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual(true, OppositesAttract.LoveFunc(1, 4));
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual(false, OppositesAttract.LoveFunc(2, 2));
        }

        [Test]
        public void Test3()
        {
            Assert.AreEqual(true, OppositesAttract.LoveFunc(0, 1));
        }

        [Test]
        public void Test4()
        {
            Assert.AreEqual(false, OppositesAttract.LoveFunc(0, 0));
        }
    }
}
