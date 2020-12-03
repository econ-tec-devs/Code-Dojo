// -----------------------------------------------------------------------
// <copyright file="UnitTest1.cs" company="econ-tec GmbH">
//     Copyright (c) econ-tec GmbH. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------
namespace KataTest
{
    using System.Collections.Generic;
    using NUnit.Framework;

    public class PotterTests
    {
        private Potter target;

        private decimal priceOneBook = 8m;

        [SetUp]
        public void Setup()
        {
            this.target = new Potter();
        }

        [Test]
        public void Calculate_EmptyListWithCountOfSameBooks_Return0()
        {
            var countOfSameBooks = new List<int>();
            var expected = 0m;

            ActAndAssert(countOfSameBooks, expected);
        }

        [Test]
        public void Calculate_ListWithOneSameBook_Return8()
        {
            var countOfSameBooks = new List<int>() { 1 };
            var expected = priceOneBook;

            ActAndAssert(countOfSameBooks, expected);
        }

        [Test]
        public void Calculate_ListWithTwoSameBooks_Return16()
        {
            var countOfSameBooks = new List<int>() { 2 };
            var expected = priceOneBook * 2;

            ActAndAssert(countOfSameBooks, expected);
        }

        [Test]
        public void Calculate_ListWithThreeSameBooks_Return24()
        {
            var countOfSameBooks = new List<int>() { 3 };
            var expected = priceOneBook * 3;

            ActAndAssert(countOfSameBooks, expected);
        }

        [Test]
        public void Calculate_ListWithFourSameBooks_Return32()
        {
            var countOfSameBooks = new List<int>() { 4 };
            var expected = priceOneBook * 4;

            ActAndAssert(countOfSameBooks, expected);
        }

        [Test]
        public void Calculate_ListWithTwoSameBooks_Return40()
        {
            var countOfSameBooks = new List<int>() { 5 };
            var expected = priceOneBook * 5;

            ActAndAssert(countOfSameBooks, expected);
        }

        [Test]
        public void Calculate_ListWithTwoDifferentBooks_Return15_20()
        {
            var countOfSameBooks = new List<int>() { 1, 1 };
            var expected = 15.2m;

            ActAndAssert(countOfSameBooks, expected);
        }

        private void ActAndAssert(List<int> countOfSameBooks, decimal expected)
        {
            var actual = this.target.Calculate(countOfSameBooks);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
