using CodeWars._8_kyu;
using NUnit.Framework;

namespace CodeWarsTests._8_kyu
{
    [TestFixture]
    public class KataNameShufflerTests
    {
        [Test, Description("Sample Tests")]
        public void SampleTest()
        {
            Assert.AreEqual("McClane john", KataNameShuffler.NameShuffler("john McClane"));
            Assert.AreEqual("jeggins Mary", KataNameShuffler.NameShuffler("Mary jeggins"));
            Assert.AreEqual("jerry tom", KataNameShuffler.NameShuffler("tom jerry"));
        }
    }
}
