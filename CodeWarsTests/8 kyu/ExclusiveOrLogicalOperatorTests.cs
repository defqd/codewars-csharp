using CodeWars._8_kyu;
using NUnit.Framework;

namespace CodeWarsTests._8_kyu
{
    [TestFixture]
    public class ExclusiveOrLogicalOperatorTests
    {
        [Test]
        public void BasicTests()
        {
            testing(ExclusiveOrLogicalOperator.Xor(false, false), false);
            testing(ExclusiveOrLogicalOperator.Xor(true, false), true);
            testing(ExclusiveOrLogicalOperator.Xor(false, true), true);
            testing(ExclusiveOrLogicalOperator.Xor(true, true), false);
        }

        [Test]
        public void NestedTests()
        {
            testing(ExclusiveOrLogicalOperator.Xor(false, ExclusiveOrLogicalOperator.Xor(false, false)), false);
            testing(ExclusiveOrLogicalOperator.Xor(ExclusiveOrLogicalOperator.Xor(true, false), false), true);
            testing(ExclusiveOrLogicalOperator.Xor(ExclusiveOrLogicalOperator.Xor(true, true), false), false);
            testing(ExclusiveOrLogicalOperator.Xor(true, ExclusiveOrLogicalOperator.Xor(true, true)), true);
            testing(ExclusiveOrLogicalOperator.Xor(ExclusiveOrLogicalOperator.Xor(false, false),
                ExclusiveOrLogicalOperator.Xor(false, false)), false);
            testing(ExclusiveOrLogicalOperator.Xor(ExclusiveOrLogicalOperator.Xor(false, false),
                ExclusiveOrLogicalOperator.Xor(false, true)), true);
            testing(ExclusiveOrLogicalOperator.Xor(ExclusiveOrLogicalOperator.Xor(true, false),
                ExclusiveOrLogicalOperator.Xor(false, false)), true);
            testing(ExclusiveOrLogicalOperator.Xor(ExclusiveOrLogicalOperator.Xor(true, false),
                ExclusiveOrLogicalOperator.Xor(true, false)), false);
            testing(ExclusiveOrLogicalOperator.Xor(ExclusiveOrLogicalOperator.Xor(true, true), 
                ExclusiveOrLogicalOperator.Xor(true, false)), true);
            testing(ExclusiveOrLogicalOperator.Xor(ExclusiveOrLogicalOperator.Xor(true, ExclusiveOrLogicalOperator.Xor(true,
                true)), 
                ExclusiveOrLogicalOperator.Xor(ExclusiveOrLogicalOperator.Xor(true, true), false)), true);
        }
        private static void testing(bool actual, bool expected)
        {
            Assert.AreEqual(expected, actual);
        }
    }
}
