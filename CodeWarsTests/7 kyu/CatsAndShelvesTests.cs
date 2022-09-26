using CodeWars._7_kyu;
using NUnit.Framework;

namespace CodeWarsTests._7_kyu
{
    [TestFixture]
    public class CatsAndShelvesTests
    {
        private static void testing(int actual, int expected)
        {
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public static void FrezzyCat()
        {
            testing(CatsAndShelves.Cats(1, 1), 0);
        }
        [Test]
        public static void Mew()
        {
            testing(CatsAndShelves.Cats(1, 5), 2);
        }
        [Test]
        public static void OneMoreMew()
        {
            testing(CatsAndShelves.Cats(2, 5), 1);
        }
        [Test]
        public static void WoolenBag()
        {
            testing(CatsAndShelves.Cats(2, 4), 2);
        }
    }
}
