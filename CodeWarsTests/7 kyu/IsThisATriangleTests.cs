using NUnit.Framework;
using CodeWars._7_kyu;

namespace CodeWarsTests._7_kyu
{
    [TestFixture]
    public class IsThisATriangleTests
    {
        [Test]
        public void IsTriangle_ValidPostiveNumbers_ReturnsTrue()
        {
            Assert.IsTrue(IsThisATriangle.IsTriangle(5, 7, 10));
        }
    }
}
