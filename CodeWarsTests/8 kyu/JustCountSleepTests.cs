using CodeWars._8_kyu;
using NUnit.Framework;

namespace CodeWarsTests._8_kyu
{
    [TestFixture]
    public class JustCountSleepTests
    {
        [Test, Description("Example Tests")]
        public void ExampleTests()
        {
            Assert.That(JustCountSleep.CountSheep(0), Is.EqualTo(""));
            Assert.That(JustCountSleep.CountSheep(1), Is.EqualTo("1 sheep..."));
            Assert.That(JustCountSleep.CountSheep(2), Is.EqualTo("1 sheep...2 sheep..."));
            Assert.That(JustCountSleep.CountSheep(3), Is.EqualTo("1 sheep...2 sheep...3 sheep..."));
        }
    }
}
