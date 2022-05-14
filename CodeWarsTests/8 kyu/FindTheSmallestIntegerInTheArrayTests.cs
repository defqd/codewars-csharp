using CodeWars._8_kyu;
using NUnit.Framework;

namespace CodeWarsTests._8_kyu
{
    [TestFixture]
    public class FindTheSmallestIntegerInTheArrayTests
    {
        [Test]
        [TestCase(new int[] { 78, 56, 232, 12, 11, 43 }, ExpectedResult = 11)]
        [TestCase(new int[] { 78, 56, -2, 12, 8, -33 }, ExpectedResult = -33)]
        public static int FixedTest(int[] args)
        {
            return FindTheSmallestIntegerInTheArray.FindSmallestInt(args);
        }
    }
}
