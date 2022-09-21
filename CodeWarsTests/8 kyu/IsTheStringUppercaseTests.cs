using CodeWars._8_kyu;
using NUnit.Framework;

namespace CodeWarsTests._8_kyu
{
    public class IsTheStringUppercaseTests
    {
        [Test]
        [TestCase("c", ExpectedResult = false)]
        [TestCase("C", ExpectedResult = true)]
        [TestCase("hello I AM DONALD", ExpectedResult = false)]
        [TestCase("HELLO I AM DONALD", ExpectedResult = true)]
        [TestCase("ACSKLDFJSgSKLDFJSKLDFJ", ExpectedResult = false)]
        [TestCase("ACSKLDFJSGSKLDFJSKLDFJ", ExpectedResult = true)]
        public static bool FixedTest(string text)
        {
            return text.IsUpperCase();
        }
    }
}