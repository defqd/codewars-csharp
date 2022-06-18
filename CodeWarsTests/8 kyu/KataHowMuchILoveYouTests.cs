using CodeWars._8_kyu;
using NUnit.Framework;

namespace CodeWarsTests._8_kyu
{
    [TestFixture]
    public class KataHowMuchILoveYouTests
    {
        [Test]
        public void SampleTests()
        {
            Assert.AreEqual("I love you", KataHowMuchILoveYou.HowMuchILoveYou(7));
            Assert.AreEqual("a lot", KataHowMuchILoveYou.HowMuchILoveYou(3));
            Assert.AreEqual("not at all", KataHowMuchILoveYou.HowMuchILoveYou(6));
            Assert.AreEqual("not at all", KataHowMuchILoveYou.HowMuchILoveYou(12));
            Assert.AreEqual("not at all", KataHowMuchILoveYou.HowMuchILoveYou(18));
            Assert.AreEqual("passionately", KataHowMuchILoveYou.HowMuchILoveYou(16));
            Assert.AreEqual("madly", KataHowMuchILoveYou.HowMuchILoveYou(47));
        }
    }
}
