using CodeWars._8_kyu;
using NUnit.Framework;

namespace CodeWarsTests._8_kyu
{
    [TestFixture]
    public class KataArrayPlusArrayTests
    {
        [Test]
        public void BasicTest()
        {
            Assert.AreEqual(21, KataArrayPlusArray.ArrayPlusArray(new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }));
            Assert.AreEqual(-21, KataArrayPlusArray.ArrayPlusArray(new int[] { -1, -2, -3 }, new int[] { -4, -5, -6 }));
            Assert.AreEqual(15, KataArrayPlusArray.ArrayPlusArray(new int[] { 0, 0, 0 }, new int[] { 4, 5, 6 }));
            Assert.AreEqual(2100, KataArrayPlusArray.ArrayPlusArray(new int[] { 100, 200, 300 }, new int[] { 400, 500, 600 }));

        }
    }
}
