using CodeWars._8_kyu;
using NUnit.Framework;

namespace CodeWarsTests._8_kyu
{
    [TestFixture]
    public class GrasshopperTests
    {
        [Test]
        public void Test1()
        {
            Assert.That(Grasshopper.Move(0, 4), Is.EqualTo(8));
            Assert.That(Grasshopper.Move(3, 6), Is.EqualTo(15));
        }
    }
}
