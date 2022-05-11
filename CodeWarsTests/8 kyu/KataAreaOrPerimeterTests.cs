using CodeWars._8_kyu;
using NUnit.Framework;

namespace CodeWarsTests._8_kyu
{
    [TestFixture]
    public class KataAreaOrPerimeterTests
    {
        [Test]
        public void FixedTest()
        {
            Assert.AreEqual(KataAreaOrPerimeter.AreaOrPerimeter(4, 4), 16);
            Assert.AreEqual(KataAreaOrPerimeter.AreaOrPerimeter(6, 10), 32);
        }
    }
}
