using CodeWars._8_kyu;
using NUnit.Framework;

namespace CodeWarsTests._8_kyu
{
    [TestFixture]
    public class ConvertAStringToAnArrayTests
    {
        [Test]
        public void _1_Example()
        {
            Assert.AreEqual(new string[] { "Robin", "Singh" }, ConvertAStringToAnArray.StringToArray("Robin Singh"));
        }

        [Test]
        public void _2_Example()
        {
            Assert.AreEqual(new string[] { "I", "love", "arrays", "they", "are", "my", "favorite" }, ConvertAStringToAnArray.StringToArray("I love arrays they are my favorite"));
        }
    }
}
