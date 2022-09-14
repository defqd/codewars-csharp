using CodeWars._8_kyu;
using NUnit.Framework;

namespace CodeWarsTests._8_kyu
{
    [TestFixture]
    public class NameOnBillboardTests
    {
        [Test]
        public void SampleTests()
        {
            Assertion(600, "Jeong-Ho Aristotelis");
            Assertion(40, "CODEWARS", 5);
        }

        private static void Assertion(double expected, string name, double price = -1) =>
          Assert.AreEqual(
              expected,
              price == -1 ? NameOnBillboard.Billboard(name) : NameOnBillboard.Billboard(name, price),

              0.000001,

              $"\n  Name: \"{name}\"\n" +
                $"  Price: {(price == -1 ? 30 : price)}\n\n"

          );
    }
}