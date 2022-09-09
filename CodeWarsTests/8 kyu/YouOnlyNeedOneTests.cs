using CodeWars._8_kyu;
using NUnit.Framework;

namespace CodeWarsTests._8_kyu
{
    [TestFixture]
    public class YouOnlyNeedOneTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual(true, YouOnlyNeedOne.Check(new object[] { 66, 101 }, 66));
            Assert.AreEqual(true, YouOnlyNeedOne.Check(new object[] { 80, 117, 115, 104, 45, 85, 112, 115 }, 45));

            Assert.AreEqual(true, YouOnlyNeedOne.Check(new object[] { 't', 'e', 's', 't' }, 'e'));
            Assert.AreEqual(false, YouOnlyNeedOne.Check(new object[] { "what", "a", "great", "kata" }, "kat"));
        }
    }
}
