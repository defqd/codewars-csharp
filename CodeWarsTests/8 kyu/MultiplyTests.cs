using CodeWars._8_kyu;
using NUnit.Framework;

namespace CodeWarsTests._8_kyu
{
    [TestFixture]
    public class MultiplyTests
    {
        [Test]
        public void ShouldMultiple()
        {
            Assert.AreEqual(2, Multiply.multiply(2, 1));
            Assert.AreEqual(8, Multiply.multiply(2, 4));
        }
    }
}
