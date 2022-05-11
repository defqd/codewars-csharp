using CodeWars._8_kyu;
using NUnit.Framework;

namespace CodeWarsTests._8_kyu
{
    [TestFixture]
    public class ReversedWordsTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual("world! hello", ReversedWords.ReverseWords("hello world!"));
            Assert.AreEqual("this like speak doesn't yoda", ReversedWords.ReverseWords("yoda doesn't speak like this"));
            Assert.AreEqual("foobar", ReversedWords.ReverseWords("foobar"));
            Assert.AreEqual("kata editor", ReversedWords.ReverseWords("editor kata"));
            Assert.AreEqual("boat your row row row", ReversedWords.ReverseWords("row row row your boat"));
        }
    }
}
