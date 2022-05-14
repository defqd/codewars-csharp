using CodeWars._7_kyu;
using NUnit.Framework;

namespace CodeWarsTests._7_kyu
{
    [TestFixture]
    public class FindTheVowelsTests
    {
        [Test]
        public void FixedTest()
        {
            Assert.AreEqual(new int[] { }, FindTheVowels.VowelIndices("mmm"));
            Assert.AreEqual(new int[] { 1, 5 }, FindTheVowels.VowelIndices("apple"));
            Assert.AreEqual(new int[] { 2, 4 }, FindTheVowels.VowelIndices("super"));
            Assert.AreEqual(new int[] { 1, 3, 6 }, FindTheVowels.VowelIndices("orange"));
            Assert.AreEqual(new int[] { 2, 4, 7, 9, 12, 14, 16, 19, 21, 24, 25, 27, 29, 31, 32, 33 }, FindTheVowels.VowelIndices("supercalifragilisticexpialidocious"));
        }
    }
}
