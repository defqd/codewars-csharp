using CodeWars._8_kyu;
using NUnit.Framework;

namespace CodeWarsTests._8_kyu
{
    public class RemoveDuplicatesFromListTests
    {
        [Test]
        public void MyTest()
        {
            Assert.AreEqual(new int[] { 1 }, RemoveDuplicatesFromList.Distinct(new int[] { 1 }));
            Assert.AreEqual(new int[] { 1, 2 }, RemoveDuplicatesFromList.Distinct(new int[] { 1, 2 }));
            Assert.AreEqual(new int[] { 1, 2 }, RemoveDuplicatesFromList.Distinct(new int[] { 1, 1, 2 }));
        }
    }
}