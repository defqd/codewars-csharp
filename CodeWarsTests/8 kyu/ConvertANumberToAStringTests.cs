using CodeWars._8_kyu;
using NUnit.Framework;
using System.Collections.Generic;

namespace CodeWarsTests._8_kyu
{
    [TestFixture]
    public class ConvertANumberToAStringTests
    {
        private static IEnumerable<TestCaseData> testCases
        {
            get
            {
                yield return new TestCaseData(67).Returns("67");
                yield return new TestCaseData(79585).Returns("79585");
                yield return new TestCaseData(1 + 2).Returns("3");
                yield return new TestCaseData(1 - 2).Returns("-1");
            }
        }

        [Test, TestCaseSource("testCases")]
        public string Test(int num) => ConvertANumberToAString.NumberToString(num);
    }
}
