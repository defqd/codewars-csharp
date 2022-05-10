using CodeWars._8_kyu;
using NUnit.Framework;

namespace CodeWarsTests._8_kyu
{
    [TestFixture]
    public class DnaToRnaConversionTests
    {
        [Test]
        public void test()
        {
            DnaToRnaConversion converter = new DnaToRnaConversion();
            Assert.AreEqual("UUUU", converter.dnaToRna("TTTT"));
        }
    }
}
