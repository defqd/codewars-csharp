using CodeWars._8_kyu;
using NUnit.Framework;

namespace CodeWarsTests._8_kyu
{
    [TestFixture]
    public class ExclamationMarksSeriesSixTests
    {
        [Test, Description("It should work for basic tests")]
        public void SampleTest()
        {
            Assert.AreEqual("Hi", ExclamationMarksSeriesSix.Remove("Hi!", 1));
            Assert.AreEqual("Hi", ExclamationMarksSeriesSix.Remove("Hi!", 100));
            Assert.AreEqual("Hi!!", ExclamationMarksSeriesSix.Remove("Hi!!!", 1));
            Assert.AreEqual("Hi", ExclamationMarksSeriesSix.Remove("Hi!!!", 100));
            Assert.AreEqual("Hi", ExclamationMarksSeriesSix.Remove("!Hi", 1));
            Assert.AreEqual("Hi!", ExclamationMarksSeriesSix.Remove("!Hi!", 1));
            Assert.AreEqual("Hi", ExclamationMarksSeriesSix.Remove("!Hi!", 100));
            Assert.AreEqual("!!Hi !!hi!!! !hi", ExclamationMarksSeriesSix.Remove("!!!Hi !!hi!!! !hi", 1));
            Assert.AreEqual("Hi !!hi!!! !hi", ExclamationMarksSeriesSix.Remove("!!!Hi !!hi!!! !hi", 3));
            Assert.AreEqual("Hi hi!!! !hi", ExclamationMarksSeriesSix.Remove("!!!Hi !!hi!!! !hi", 5));
            Assert.AreEqual("Hi hi hi", ExclamationMarksSeriesSix.Remove("!!!Hi !!hi!!! !hi", 100));
        }
    }
}
