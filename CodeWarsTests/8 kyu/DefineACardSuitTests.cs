using CodeWars._8_kyu;
using NUnit.Framework;

namespace CodeWarsTests._8_kyu
{
    public class DefineACardSuitTests
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual("clubs", DefineACardSuit.DefineSuit("3♣"), "Should return clubs with \"3♣\"");
            Assert.AreEqual("spades", DefineACardSuit.DefineSuit("Q♠"), "Should return spades with \"Q♠\"");
            Assert.AreEqual("diamonds", DefineACardSuit.DefineSuit("9♦"), "Should return diamonds with \"9♦\"");
            Assert.AreEqual("hearts", DefineACardSuit.DefineSuit("J♥"), "Should return hearts with \"J♥\"");
        }
    }

}
