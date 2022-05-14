using CodeWars._8_kyu;
using NUnit.Framework;

namespace CodeWarsTests._8_kyu
{
    [TestFixture]
    public class HowGoodAreYouReallyTests
    {
        [Test]
        [TestCase(new int[] { 2, 3 }, 5, ExpectedResult = true)]
        [TestCase(new int[] { 100, 40, 34, 57, 29, 72, 57, 88 }, 75, ExpectedResult = true)]
        [TestCase(new int[] { 12, 23, 34, 45, 56, 67, 78, 89, 90 }, 69, ExpectedResult = true)]
        public static bool FixedTest(int[] arr, int num)
        {
            return HowGoodAreYouReally.BetterThanAverage(arr, num);
        }
    }
}
