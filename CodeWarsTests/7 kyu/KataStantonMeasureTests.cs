using CodeWars._7_kyu;
using NUnit.Framework;

namespace CodeWarsTests._7_kyu
{
    [TestFixture]
    public class KataStantonMeasureTests
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual(3, KataStantonMeasure.StantonMeasure(new int[] { 1, 4, 3, 2, 1, 2, 3, 2 }));
            Assert.AreEqual(1, KataStantonMeasure.StantonMeasure(new int[] { 1, 4, 1, 2, 11, 2, 3, 1 }));
        }
    }
}
