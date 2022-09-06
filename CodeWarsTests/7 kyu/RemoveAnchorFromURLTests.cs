using CodeWars._7_kyu;
using NUnit.Framework;

namespace CodeWarsTests._7_kyu
{
    [TestFixture]
    public class RemoveAnchorFromURLTests
    {
        [Test, Description("Sample Tests")]
        public void SampleTests()
        {
            Assert.AreEqual("www.codewars.com", RemoveAnchorFromURL.RemoveUrlAnchor("www.codewars.com#about"));
            Assert.AreEqual("www.codewars.com/katas/?page=1", RemoveAnchorFromURL.RemoveUrlAnchor("www.codewars.com/katas/?page=1#about"));
            Assert.AreEqual("www.codewars.com/katas/", RemoveAnchorFromURL.RemoveUrlAnchor("www.codewars.com/katas/"));
        }
    }
}
