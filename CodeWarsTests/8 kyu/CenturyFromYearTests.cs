using CodeWars._8_kyu;
using NUnit.Framework;

namespace CodeWarsTests._8_kyu
{
    [TestFixture]
    public class CenturyFromYearTests
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual(18, CenturyFromYear.СenturyFromYear(1705));
            Assert.AreEqual(19, CenturyFromYear.СenturyFromYear(1900));
            Assert.AreEqual(17, CenturyFromYear.СenturyFromYear(1601));
            Assert.AreEqual(20, CenturyFromYear.СenturyFromYear(2000));
        }
    }
}
