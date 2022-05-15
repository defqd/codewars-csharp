using CodeWars._8_kyu;
using NUnit.Framework;
using System.Collections.Generic;

namespace CodeWarsTests._8_kyu
{
    [TestFixture]
    public class RemovingElementsTests
    {
        [Test]
        public void BasicTest()
        {
            Assert.AreEqual(new object[] { "Hello", "Hello Again" }, RemovingElements.RemoveEveryOther(new object[] { "Hello", "Goodbye", "Hello Again" }));
            Assert.AreEqual(new object[] { new object[] { 1, 2 } }, RemovingElements.RemoveEveryOther(new object[] { new object[] { 1, 2 } }));
            Assert.AreEqual(new object[] { 1, 3, 5, 7, 9 }, RemovingElements.RemoveEveryOther(new object[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }));
            Assert.AreEqual(new object[] { new object[] { "Goodbye" } }, RemovingElements.RemoveEveryOther(new object[] { new object[] { "Goodbye" }, new Dictionary<string, string>() { { "Great", "Job" } } }));
            Assert.AreEqual(new object[] { }, RemovingElements.RemoveEveryOther(new object[] { }));
        }
    }
}
