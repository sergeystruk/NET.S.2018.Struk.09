using System;
using NUnit.Framework;

namespace ArrayUtil.Tests
{
    [TestFixture]
    public class ArrayModifierTests
    {
        private int[] testArray = {13, -26, -1199, 11, -6, 0, -117, 14, -90};

        [Test]
        public void FilterDigitsTest_NumberIsPositive()
        {
            int[] expectedArray = {13, 11, 14};

            CollectionAssert.AreEqual(expectedArray, ArrayModifier.FilterDigits(testArray, new PredicateNumberIsPositive()));
        }

        [Test]
        public void FilterDigitsTest_NumberContainsDigit()
        {
            int[] expectedArray = {-1199, -90};

            CollectionAssert.AreEqual(expectedArray, ArrayModifier.FilterDigits(testArray, new PredicateNumberContainsDigit()));
        }

        [Test]
        public void FilterDigitsTest_NumberIsDividedByValue()
        {
            int[] expectedArray = { 13, -26, 0, -117};

            CollectionAssert.AreEqual(expectedArray, ArrayModifier.FilterDigits(testArray, new PredicateNumberIsDividedByValue()));
        }

        [Test]
        public void FilterDigitsTest_WithNullArray()
        {
            Assert.Throws<ArgumentNullException>(() => ArrayModifier.FilterDigits(null, new PredicateNumberContainsDigit()));
        }

        [Test]
        public void FilterDigitsTest_WithNullPredicate()
        {
            Assert.Throws<ArgumentNullException>(() => ArrayModifier.FilterDigits(testArray, null));
        }
    }
}
