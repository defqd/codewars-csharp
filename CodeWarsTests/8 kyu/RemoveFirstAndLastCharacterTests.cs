using CodeWars._8_kyu;
using NUnit.Framework;

namespace CodeWarsTests._8_kyu
{
    [TestFixture]
    public class RemoveFirstAndLastCharacterTests
    {
        [Test]
        public void Test1()
        {
            StringAssert.AreEqualIgnoringCase("loquen", RemoveFirstAndLastCharacter.Remove_char("eloquent"));
            StringAssert.AreEqualIgnoringCase("ountr", RemoveFirstAndLastCharacter.Remove_char("country"));
            StringAssert.AreEqualIgnoringCase("erso", RemoveFirstAndLastCharacter.Remove_char("person"));
            StringAssert.AreEqualIgnoringCase("lac", RemoveFirstAndLastCharacter.Remove_char("place"));
            StringAssert.AreEqualIgnoringCase("", RemoveFirstAndLastCharacter.Remove_char("ok"));
        }
    }
}
