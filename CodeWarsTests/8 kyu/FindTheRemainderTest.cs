using CodeWars._8_kyu;
using NUnit.Framework;
using System;

namespace CodeWarsTests._8_kyu
{
    [TestFixture]
    public class FindTheRemainderTest
    {
        [Test, Description("Your solution should handle arguments and math as defined in specifications")]
        public void FixedTest()
        {
            Assert.AreEqual(2, FindTheRemainder.Remainder(17, 5), "Returned value should be the value left over after dividing as much as possible.");
            Assert.AreEqual(FindTheRemainder.Remainder(72, 13), FindTheRemainder.Remainder(13, 72), "The order the arguments are passed should not matter.");
            Assert.Throws<DivideByZeroException>(() => FindTheRemainder.Remainder(0, 1));
            Assert.Throws<DivideByZeroException>(() => FindTheRemainder.Remainder(0, 0));
        }
    }
}
