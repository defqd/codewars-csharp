using CodeWars._8_kyu;
using NUnit.Framework;

namespace CodeWarsTests._8_kyu
{
    [TestFixture]
    public class OppositeNumberTests
    {
        [Test]
        public void Test_1()
        {
            Assert.AreEqual(-1, OppositeNumber.Opposite(1));
        }
    }
}
