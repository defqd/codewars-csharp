using System;
using CodeWars._7_kyu;
using NUnit.Framework;

namespace CodeWarsTests._7_kyu
{
    [TestFixture]
    public class GrowthOfAPopulationTests
    {
        private static void testing(int actual, int expected)
        {
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public static void test1()
        {
            Console.WriteLine("Testing NbYear");
            testing(GrowthOfAPopulation.NbYear(1500, 5, 100, 5000), 15);
            testing(GrowthOfAPopulation.NbYear(1500000, 2.5, 10000, 2000000), 10);
            testing(GrowthOfAPopulation.NbYear(1500000, 0.25, 1000, 2000000), 94);
        }
    }
}
