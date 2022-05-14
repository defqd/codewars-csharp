using CodeWars._8_kyu;
using NUnit.Framework;

namespace CodeWarsTests._8_kyu
{
    [TestFixture]
    public class CheckSameCaseTests
    {
        [Test]
        public void TrueTests()
        {
            Assert.AreEqual(1, CheckSameCase.SameCase('a', 'u'));
            Assert.AreEqual(1, CheckSameCase.SameCase('A', 'U'));
            Assert.AreEqual(1, CheckSameCase.SameCase('Q', 'P'));
            Assert.AreEqual(1, CheckSameCase.SameCase('w', 'y'));
            Assert.AreEqual(1, CheckSameCase.SameCase('c', 'm'));
            Assert.AreEqual(1, CheckSameCase.SameCase('N', 'W'));
        }
        [Test]
        public void FalseTests()
        {
            Assert.AreEqual(0, CheckSameCase.SameCase('a', 'U'));
            Assert.AreEqual(0, CheckSameCase.SameCase('A', 'u'));
            Assert.AreEqual(0, CheckSameCase.SameCase('Q', 'p'));
            Assert.AreEqual(0, CheckSameCase.SameCase('w', 'Y'));
            Assert.AreEqual(0, CheckSameCase.SameCase('c', 'M'));
            Assert.AreEqual(0, CheckSameCase.SameCase('N', 'w'));
        }
        [Test]
        public void NotLetters()
        {
            Assert.AreEqual(-1, CheckSameCase.SameCase('a', '*'));
            Assert.AreEqual(-1, CheckSameCase.SameCase('A', '%'));
            Assert.AreEqual(-1, CheckSameCase.SameCase('Q', '1'));
            Assert.AreEqual(-1, CheckSameCase.SameCase('w', '-'));
            Assert.AreEqual(-1, CheckSameCase.SameCase('c', '8'));
            Assert.AreEqual(-1, CheckSameCase.SameCase('N', ':'));
        }
    }
}
