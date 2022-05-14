using CodeWars._8_kyu;
using NUnit.Framework;

namespace CodeWarsTests._8_kyu
{
    [TestFixture]
    public class HelloNameOrWorldTests
    {
        [Test]
        public void BasicTest()
        {
            Assert.AreEqual("Hello, Jeff!", HelloNameOrWorld.Hello("jEFF"));
            Assert.AreEqual("Hello, Tony!", HelloNameOrWorld.Hello("tonY"));
            Assert.AreEqual("Hello, Alicia!", HelloNameOrWorld.Hello("Alicia"));
            Assert.AreEqual("Hello, Vasya!", HelloNameOrWorld.Hello("vasya"));
            Assert.AreEqual("Hello, John!", HelloNameOrWorld.Hello("JOHN"));
            Assert.AreEqual("Hello, World!", HelloNameOrWorld.Hello(""));
            Assert.AreEqual("Hello, World!", HelloNameOrWorld.Hello());
        }
    }
}
