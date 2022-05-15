using CodeWars._8_kyu;
using NUnit.Framework;

namespace CodeWarsTests._8_kyu
{
    [TestFixture]
    public class CountOfPositivesSumOfNegativesTests
    {
        [Test]
        public void CountPositivesSumNegatives_BasicTest()
        {
            int[] expectedResult = new int[] { 10, -65 };

            Assert.AreEqual(expectedResult, CountOfPositivesSumOfNegatives.CountPositivesSumNegatives(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14, -15 }));
        }

        [Test]
        public void CountPositivesSumNegatives_InputWithZeroes()
        {
            int[] expectedResult = new int[] { 8, -50 };

            Assert.AreEqual(expectedResult, CountOfPositivesSumOfNegatives.CountPositivesSumNegatives(new[] { 0, 2, 3, 0, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14 }));
        }

        [Test]
        public void CountPositivesSumNegatives_InputNull()
        {
            int[] expectedResult = new int[] { };

            Assert.AreEqual(expectedResult, CountOfPositivesSumOfNegatives.CountPositivesSumNegatives(null));
        }

        [Test]
        public void CountPositivesSumNegatives_InputEmpty()
        {
            int[] expectedResult = new int[] { };

            Assert.AreEqual(expectedResult, CountOfPositivesSumOfNegatives.CountPositivesSumNegatives(new int[] { }));
        }
    }
}
