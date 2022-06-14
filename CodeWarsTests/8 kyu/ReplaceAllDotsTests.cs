using CodeWars._8_kyu;
using NUnit.Framework;

namespace CodeWarsTests._8_kyu
{
    [TestFixture]
    public class ReplaceAllDotsTests
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual("one-two-three", ReplaceAllDots.ReplaceDots("one.two.three"));
        }
    }
}
