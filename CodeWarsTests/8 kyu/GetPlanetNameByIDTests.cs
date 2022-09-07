using CodeWars._8_kyu;
using NUnit.Framework;

namespace CodeWarsTests._8_kyu
{
    [TestFixture]
    public class GetPlanetNameByIDTests
    {
        [Test]
        public void Test()
        {
            Assert.AreEqual("Venus", GetPlanetNameByID.GetPlanetName(2));
            Assert.AreEqual("Jupiter", GetPlanetNameByID.GetPlanetName(5));
        }
    }
}
