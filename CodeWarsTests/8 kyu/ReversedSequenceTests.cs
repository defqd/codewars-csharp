using CodeWars._8_kyu;
using NUnit.Framework;

namespace CodeWarsTests._8_kyu
{
    [TestFixture]
    public class ReversedSequenceTests
    {
        [Test]
        public void SampleTest()
        {
            Assert.That(ReversedSequence.ReverseSeq(5), Is.EqualTo(new int[] { 5, 4, 3, 2, 1 }));
        }
    }
}
