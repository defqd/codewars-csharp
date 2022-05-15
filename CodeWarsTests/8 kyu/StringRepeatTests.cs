using CodeWars._8_kyu;
using NUnit.Framework;

namespace CodeWarsTests._8_kyu
{
    [TestFixture]
    public class StringRepeatTests
    {
        [Test(Description = "Fixed Tests")]
        public void FixedTests()
        {
            Assert.AreEqual("***", StringRepeat.RepeatStr(3, "*"));
            Assert.AreEqual("#####", StringRepeat.RepeatStr(5, "#"));
            Assert.AreEqual("ha ha ", StringRepeat.RepeatStr(2, "ha "));
        }
    }
}
