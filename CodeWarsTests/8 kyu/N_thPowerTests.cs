using CodeWars._8_kyu;
using NUnit.Framework;

namespace CodeWarsTests._8_kyu
{
    [TestFixture]
    public class N_thPowerTests
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual(9, N_thPower.Index(new int[] { 1, 2, 3, 4 }, 2));
            Assert.AreEqual(1000000, N_thPower.Index(new int[] { 1, 3, 10, 100 }, 3));
            Assert.AreEqual(1, N_thPower.Index(new int[] { 6, 2, 10, 200 }, 0));
            Assert.AreEqual(1, N_thPower.Index(new int[] { 0, 2, 10, 200 }, 0));
            Assert.AreEqual(1000, N_thPower.Index(new int[] { 29, 82, 45, 10}, 3));
            Assert.AreEqual(70, N_thPower.Index(new int[] { 23, 70, 48, 27, 63}, 1));          
            Assert.AreEqual(-1, N_thPower.Index(new int[] { 6, 31}, 3));        
            Assert.AreEqual(-1, N_thPower.Index(new int[] { 59, 35, 61, 97, 47, 28, 17}, 9));        
        }
    }
}