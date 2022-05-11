using CodeWars._8_kyu;
using NUnit.Framework;

namespace CodeWarsTests._8_kyu
{
    [TestFixture]
    public class SumTheStringsTests
    {
        [Test(Description = "Tests")]
        public void Tests()
        {
            Assert.AreEqual("9", SumTheStrings.StringsSum("4", "5"));
            Assert.AreEqual("39", SumTheStrings.StringsSum("34", "5"));
            Assert.AreEqual("9", SumTheStrings.StringsSum("", "9"));
            Assert.AreEqual("9", SumTheStrings.StringsSum("9", ""));
            Assert.AreEqual("0", SumTheStrings.StringsSum("", ""));
        }
    }
}
