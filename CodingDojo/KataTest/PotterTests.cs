using System.Collections.Generic;
using Kata;
using NUnit.Framework;

namespace KataTest
{
    public class PotterTests
    {
        private Potter _target;

        [SetUp]
        public void Setup()
        {
            _target = new Potter();
        }

        [Test]
        public void Calculate_EmptyListWithCountOfSameBooks_Return0()
        {
            var countOfSameBooks = new List<int>();
            var expected = 0m;

            ActAndAssert(countOfSameBooks, expected);
        }

        #region SameBooks

        [Test]
        public void Calculate_ListWithOneBook_Return8()
        {
            var countOfSameBooks = new List<int>() { 1 };
            var expected = 8m;

            ActAndAssert(countOfSameBooks, expected);
        }

        [Test]
        public void Calculate_ListWithTwoBook_Return16()
        {
            var countOfSameBooks = new List<int>() { 2 };
            var expected = 16m;

            ActAndAssert(countOfSameBooks, expected);
        }

        [Test]
        public void Calculate_ListWithTwoBook_Return24()
        {
            var countOfSameBooks = new List<int>() { 3 };
            var expected = 24m;

            ActAndAssert(countOfSameBooks, expected);
        }

        #endregion

        private void ActAndAssert(List<int> countOfSameBooks, decimal expected)
        {
            decimal actual = _target.Calculate(countOfSameBooks);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}