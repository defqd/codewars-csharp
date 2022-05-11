using CodeWars._8_kyu;
using NUnit.Framework;

namespace CodeWarsTests._8_kyu
{
    [TestFixture]
    public class ReversedStringsTests
    {
        [Test]
        public void World()
        {
            Assert.AreEqual("dlrow", ReversedStrings.Solution("world"));
        }
    }
}
