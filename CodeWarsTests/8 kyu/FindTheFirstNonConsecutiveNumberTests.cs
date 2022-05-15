using CodeWars._8_kyu;
using NUnit.Framework;

namespace CodeWarsTests._8_kyu
{
    [TestFixture]
    public class FindTheFirstNonConsecutiveNumberTests
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual(6, FindTheFirstNonConsecutiveNumber.FirstNonConsecutive(new int[] { 1, 2, 3, 4, 6, 7, 8 }));
        }
    }
}
