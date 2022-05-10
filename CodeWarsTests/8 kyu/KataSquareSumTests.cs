using CodeWars._8_kyu;
using NUnit.Framework;
using System.Collections.Generic;

namespace CodeWarsTests._8_kyu
{
    [TestFixture]
    public class KataSquareSumTests
    {
        private static IEnumerable<TestCaseData> sampleTestCases
        {
            get
            {
                yield return new TestCaseData(new int[] { 1, 2, 2 }).Returns(9);
                yield return new TestCaseData(new int[] { 1, 2 }).Returns(5);
                yield return new TestCaseData(new int[] { 5, 3, 4 }).Returns(50);
                yield return new TestCaseData(new int[] { }).Returns(0);
            }
        }
        [Test, TestCaseSource("sampleTestCases"), Description("Sample Tests")]
        public int SampleTest(int[] n) => KataSquareSum.SquareSum(n);
    }
}
