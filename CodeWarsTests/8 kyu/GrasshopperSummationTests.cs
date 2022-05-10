using CodeWars._8_kyu;
using NUnit.Framework;

namespace CodeWarsTests._8_kyu
{
    [TestFixture]
    public class GrasshopperSummationTests
    {
        [Test]
        public static void BasicTests()
        {
            Assert.AreEqual(1, GrasshopperSummation.Summation(1));
            Assert.AreEqual(36, GrasshopperSummation.Summation(8));
            Assert.AreEqual(253, GrasshopperSummation.Summation(22));
            Assert.AreEqual(5050, GrasshopperSummation.Summation(100));
            Assert.AreEqual(22791, GrasshopperSummation.Summation(213));
        }
    }
}
