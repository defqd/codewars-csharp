using CodeWars._7_kyu;
using NUnit.Framework;

namespace CodeWarsTests._7_kyu
{

    [TestFixture]
    public class DeodorantEvaporatorTests
    {

        [Test]
        public void Test1()
        {
            Assert.AreEqual(22, DeodorantEvaporator.Evaporator(10, 10, 10));
            Assert.AreEqual(29, DeodorantEvaporator.Evaporator(10, 10, 5));
        }
    }
}
