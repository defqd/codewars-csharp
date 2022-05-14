using CodeWars._7_kyu;
using NUnit.Framework;

namespace CodeWarsTests._7_kyu
{
    [TestFixture]
    public class GetTheMiddleCharacterTests
    {
        [Test]
        public void GenericTests()
        {
            Assert.AreEqual("es", GetTheMiddleCharacter.GetMiddle("test"));
            Assert.AreEqual("t", GetTheMiddleCharacter.GetMiddle("testing"));
            Assert.AreEqual("dd", GetTheMiddleCharacter.GetMiddle("middle"));
            Assert.AreEqual("A", GetTheMiddleCharacter.GetMiddle("A"));
        }
    }
}
