using CodeWars._7_kyu;
using NUnit.Framework;

namespace CodeWarsTests._7_kyu
{
    [TestFixture]
    public class ConsecutiveItemsTests
    {
        [Test]
        public void MyTest()
        {
            Assert.AreEqual(false, ConsecutiveItems.Consecutive(new int[] { 1, 3, 5, 7 }, 3, 7));
            Assert.AreEqual(true, ConsecutiveItems.Consecutive(new int[] { 1, 3, 5, 7 }, 3, 1));
            Assert.AreEqual(true, ConsecutiveItems.Consecutive(new int[] { 1, 6, 9, -3, 4, -78, 0 }, -3, 4));
        }
    }
}
