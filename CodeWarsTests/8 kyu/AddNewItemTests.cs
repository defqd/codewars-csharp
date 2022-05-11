using CodeWars._8_kyu;
using NUnit.Framework;
using System.Collections.Generic;

namespace CodeWarsTests._8_kyu
{
    [TestFixture]
    public class AddNewItemTests
    {
        [Test]
        public void FirstTest()
        {
            List<int> listOfNumbers = new List<int>() { 1, 2, 2, 2, 4, 3, 4, 5, 6, 7 };
            Assert.AreEqual((AddNewItem.AddExtra(listOfNumbers)).Count, listOfNumbers.Count + 1);
        }
    }
}
