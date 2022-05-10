using CodeWars._8_kyu;
using NUnit.Framework;

namespace CodeWarsTests._8_kyu
{
    [TestFixture]
    public class BeginnerReduceButGrowTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual(6, BeginnerReduceButGrow.Grow(new[] { 1, 2, 3 }));
            Assert.AreEqual(16, BeginnerReduceButGrow.Grow(new[] { 4, 1, 1, 1, 4 }));
            Assert.AreEqual(64, BeginnerReduceButGrow.Grow(new[] { 2, 2, 2, 2, 2, 2 }));
        }
    }
}
