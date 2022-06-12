using CodeWars._8_kyu;
using NUnit.Framework;

namespace CodeWarsTests._8_kyu
{
    [TestFixture]
    public class KataDoubleCharTests
    {
        [Test]
        [TestCase("abcd", ExpectedResult = "aabbccdd")]
        [TestCase("Adidas", ExpectedResult = "AAddiiddaass")]
        [TestCase("1337", ExpectedResult = "11333377")]
        [TestCase("illuminati", ExpectedResult = "iilllluummiinnaattii")]
        [TestCase("123456", ExpectedResult = "112233445566")]
        [TestCase("%^&*(", ExpectedResult = "%%^^&&**((")]
        public static string FixedTest(string s)
        {
            return KataDoubleChar.DoubleChar(s);
        }
    }
}
