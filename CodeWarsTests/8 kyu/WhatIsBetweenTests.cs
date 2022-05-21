using CodeWars._8_kyu;
using NUnit.Framework;

namespace CodeWarsTests._8_kyu
{
    [TestFixture]
    public class WhatIsBetweenTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual(new int[] { 0, 1, 2, 3 }, WhatIsBetween.Between(0, 3));
            Assert.AreEqual(new int[] { -2, -1, 0, 1, 2 }, WhatIsBetween.Between(-2, 2));
            Assert.AreEqual(new int[] { -10, -9, -8, -7, -6, -5, -4, -3, -2, -1, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, WhatIsBetween.Between(-10, 10));
        }
    }
}
