using CodeWars._8_kyu;
using NUnit.Framework;
using System;

namespace CodeWarsTests._8_kyu
{
    [TestFixture]
    public class MyHeadIsAtTheWrongEndTests
    {
        private static Random rnd = new Random();

        [Test]
        public void SampleTest()
        {
            Assert.AreEqual(new string[] { "head", "body", "tail" }, MyHeadIsAtTheWrongEnd.FixTheMeerkat(new string[] { "tail", "body", "head" }));
            Assert.AreEqual(new string[] { "heads", "body", "tails" }, MyHeadIsAtTheWrongEnd.FixTheMeerkat(new string[] { "tails", "body", "heads" }));
            Assert.AreEqual(new string[] { "top", "middle", "bottom" }, MyHeadIsAtTheWrongEnd.FixTheMeerkat(new string[] { "bottom", "middle", "top" }));
            Assert.AreEqual(new string[] { "upper legs", "torso", "lower legs" }, MyHeadIsAtTheWrongEnd.FixTheMeerkat(new string[] { "lower legs", "torso", "upper legs" }));
            Assert.AreEqual(new string[] { "ground", "rainbow", "sky" }, MyHeadIsAtTheWrongEnd.FixTheMeerkat(new string[] { "sky", "rainbow", "ground" }));
        }
    }
}
