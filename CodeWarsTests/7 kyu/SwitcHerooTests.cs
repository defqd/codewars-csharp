using CodeWars._7_kyu;
using NUnit.Framework;

namespace CodeWarsTests._7_kyu
{
    public class SwitcHerooTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual("bac", SwitcHeroo.Switcheroo("abc"));
            Assert.AreEqual("bbbacccabbb", SwitcHeroo.Switcheroo("aaabcccbaaa"));
            Assert.AreEqual("ccccc", SwitcHeroo.Switcheroo("ccccc"));
        }
    }
}
