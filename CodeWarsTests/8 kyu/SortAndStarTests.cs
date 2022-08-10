using CodeWars._8_kyu;
using NUnit.Framework;

namespace CodeWarsTests._8_kyu
{
    [TestFixture]
    public class SortAndStarTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual("b***i***t***c***o***i***n", SortAndStar.TwoSort(new[] { "bitcoin", "take", "over", "the", "world", "maybe", "who", "knows", "perhaps" }));
            Assert.AreEqual("a***r***e", SortAndStar.TwoSort(new[] { "turns", "out", "random", "test", "cases", "are", "easier", "than", "writing", "out", "basic", "ones" }));
            Assert.AreEqual("L***e***t***s", SortAndStar.TwoSort(new[] { "writing","world", "maybe","Lets","all" }));
            Assert.AreEqual("B***T***C", SortAndStar.TwoSort(new[] { "writing","world", "maybe","Lets","all", "Bitcoin", "BTC" }));
        }
    }
}
