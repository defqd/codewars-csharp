using CodeWars._8_kyu;
using NUnit.Framework;

namespace CodeWarsTests._8_kyu
{
    [TestFixture]
    public class BeginnerLostWithoutAMapTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual(new[] { 2, 4, 6 }, BeginnerLostWithoutAMap.Maps(new[] { 1, 2, 3 }));
            Assert.AreEqual(new[] { 8, 2, 2, 2, 8 }, BeginnerLostWithoutAMap.Maps(new[] { 4, 1, 1, 1, 4 }));
            Assert.AreEqual(new[] { 4, 4, 4, 4, 4, 4 }, BeginnerLostWithoutAMap.Maps(new[] { 2, 2, 2, 2, 2, 2 }));
        }
    }
}
