using CodeWars._8_kyu;
using NUnit.Framework;

namespace CodeWarsTests._8_kyu
{
    [TestFixture]
    public class VolumeOfACuboidTests
    {
        [Test]
        public void SampleTests()
        {
            Assert.AreEqual(60, VolumeOfACuboid.GetVolumeOfCubiod(2, 5, 6), 0.00001, "Length: 2, Width: 5, Height: 6");
            Assert.AreEqual(94.5, VolumeOfACuboid.GetVolumeOfCubiod(6.3, 3, 5), 0.00001, "Length: 6.3, Width: 3, Height: 5");
        }
    }
}
