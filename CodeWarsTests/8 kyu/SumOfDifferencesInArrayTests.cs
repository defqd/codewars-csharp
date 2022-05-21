using CodeWars._8_kyu;
using NUnit.Framework;

namespace CodeWarsTests._8_kyu
{
    public class SumOfDifferencesInArrayTests
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual(0, SumOfDifferencesInArray.SumOfDifferences(new int[] { }));
            Assert.AreEqual(0, SumOfDifferencesInArray.SumOfDifferences(new int[] { 0 }));
            Assert.AreEqual(0, SumOfDifferencesInArray.SumOfDifferences(new int[] { 1 }));
            Assert.AreEqual(0, SumOfDifferencesInArray.SumOfDifferences(new int[] { -1 }));
            Assert.AreEqual(34, SumOfDifferencesInArray.SumOfDifferences(new int[] { -17, 17 }));
            Assert.AreEqual(9, SumOfDifferencesInArray.SumOfDifferences(new int[] { 2, 1, 10 }));
            Assert.AreEqual(2, SumOfDifferencesInArray.SumOfDifferences(new int[] { -3, -2, -1 }));
            Assert.AreEqual(0, SumOfDifferencesInArray.SumOfDifferences(new int[] { 1, 1, 1, 1, 1 }));
            Assert.AreEqual(0, SumOfDifferencesInArray.SumOfDifferences(new int[] { 0, 0, 0, 0, 0 }));
            Assert.AreEqual(4, SumOfDifferencesInArray.SumOfDifferences(new int[] { 1, 2, 3, 4, 5 }));
            Assert.AreEqual(29, SumOfDifferencesInArray.SumOfDifferences(new int[] { 0, 29, 24, 17 }));
            Assert.AreEqual(50, SumOfDifferencesInArray.SumOfDifferences(new int[] { 25, 24, -25, 2 }));
            Assert.AreEqual(22, SumOfDifferencesInArray.SumOfDifferences(new int[] { -26, -4, -8, -8 }));
        }
    }
}
