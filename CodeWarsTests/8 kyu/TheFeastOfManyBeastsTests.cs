using CodeWars._8_kyu;
using NUnit.Framework;

namespace CodeWarsTests._8_kyu
{
    [TestFixture]
    public class TheFeastOfManyBeastsTests
    {
        [TestCase("great blue heron", "garlic naan")]
        [TestCase("chickadee", "chocolate cake")]
        public void BasicTestsTrue(string beast, string dish)
        {
            Assert.IsTrue(TheFeastOfManyBeasts.Feast(beast, dish));
        }

        [TestCase("brown bear", "bear claw")]
        public void BasicTestsFalse(string beast, string dish)
        {
            Assert.IsFalse(TheFeastOfManyBeasts.Feast(beast, dish));
        }
    }
}
