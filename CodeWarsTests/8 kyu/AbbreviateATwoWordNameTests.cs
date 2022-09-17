using CodeWars._8_kyu;
using NUnit.Framework;

namespace CodeWarsTests._8_kyu
{
    public class AbbreviateATwoWordNameTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual("S.H", AbbreviateATwoWordName.AbbrevName("Sam Harris"));
            Assert.AreEqual("P.F", AbbreviateATwoWordName.AbbrevName("Patrick Feenan"));
            Assert.AreEqual("E.C", AbbreviateATwoWordName.AbbrevName("Evan Cole"));
            Assert.AreEqual("P.F", AbbreviateATwoWordName.AbbrevName("P Favuzzi"));
            Assert.AreEqual("D.M", AbbreviateATwoWordName.AbbrevName("David Mendieta"));
        }
    }
}
