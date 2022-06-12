using CodeWars._7_kyu;
using NUnit.Framework;

namespace CodeWarsTests._7_kyu
{
    [TestFixture]
    public class KnightKingTests
    {
        [Test]
        public void KnightTest()
        {
            object[] kingPosition = { 4, "C" };
            object[] knightPosition = { 6, "D" };
            StringAssert.AreEqualIgnoringCase("Knight", KnightKing.KnightVsKing(knightPosition, kingPosition));
        }
        [Test]
        public void KingTest()
        {
            object[] kingPosition = { 7, "B" };
            object[] knightPosition = { 6, "C" };
            StringAssert.AreEqualIgnoringCase("King", KnightKing.KnightVsKing(knightPosition, kingPosition));
        }
        [Test]
        public void NoneTest()
        {
            object[] kingPosition = { 2, "F" };
            object[] knightPosition = { 6, "B" };
            StringAssert.AreEqualIgnoringCase("None", KnightKing.KnightVsKing(knightPosition, kingPosition));
        }
    }
}
