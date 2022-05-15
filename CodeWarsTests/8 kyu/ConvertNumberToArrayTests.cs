using CodeWars._8_kyu;
using NUnit.Framework;

namespace CodeWarsTests._8_kyu
{
    [TestFixture]
    public class ConvertNumberToArrayTests
    {
        [Test]
        public void MyTest()
        {
            Assert.AreEqual(new long[] { 1, 3, 2, 5, 3 }, ConvertNumberToArray.Digitize(35231));
            Assert.AreEqual(new long[] { 0 }, ConvertNumberToArray.Digitize(0));
        }
    }
}
