using CodeWars._8_kyu;
using NUnit.Framework;

namespace CodeWarsTests._8_kyu
{
    [TestFixture]
    public class DoIGetABonusTests
    {
        [Test]
        public void BasicTest()
        {
            StringAssert.AreEqualIgnoringCase("$100000", DoIGetABonus.bonus_time(10000, true));
            StringAssert.AreEqualIgnoringCase("$250000", DoIGetABonus.bonus_time(25000, true));
            StringAssert.AreEqualIgnoringCase("$10000", DoIGetABonus.bonus_time(10000, false));
            StringAssert.AreEqualIgnoringCase("$60000", DoIGetABonus.bonus_time(60000, false));
            StringAssert.AreEqualIgnoringCase("$20", DoIGetABonus.bonus_time(2, true));
            StringAssert.AreEqualIgnoringCase("$78", DoIGetABonus.bonus_time(78, false));
            StringAssert.AreEqualIgnoringCase("$678900", DoIGetABonus.bonus_time(67890, true));
        }
    }

}
