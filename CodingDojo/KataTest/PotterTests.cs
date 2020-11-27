using System.Collections.Generic;
using KataPotter;
using NUnit.Framework;

namespace KataTest
{
    public class PotterTests
    {
        private Potter target;
        private List<int> countOfDifferentBooks;

        [SetUp]
        public void Setup()
        {
            target = new Potter();
            countOfDifferentBooks = new List<int>();
        }

        public void ActAndAssert(int countOfSameBooks, decimal expected)
        {
            countOfDifferentBooks.Add(countOfSameBooks);
            var actual = target.Calculate(countOfDifferentBooks);
            Assert.That(actual, Is.EqualTo(expected));
        }

        public void ActAndAssert(List<int> countOfDifferentBooks, decimal expected)
        {
            var actual = target.Calculate(countOfDifferentBooks);
            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCase(0, 0.00)]
        [TestCase(1, 8.00)]
        [TestCase(2, 16.00)]
        [TestCase(3, 24.00)]
        [TestCase(4, 32.00)]
        [TestCase(10, 80.00)]
        public void Calculate_ListWithCountOfSameBook_ReturnFullPrice(int countOfSameBooks, decimal fullPrice)
        {
            this.ActAndAssert(countOfSameBooks, fullPrice);
        }

        [Test]
        public void Calculate_ListWithZeroFirstBookAndTwoSecondBook_Return16()
        {
            countOfDifferentBooks.Add(0);
            countOfDifferentBooks.Add(2);
            this.ActAndAssert(countOfDifferentBooks, 16m);
        }

        [Test]
        public void Calculate_ListWithZeroFirstBookAndThreeSecondBook_Return24()
        {
            countOfDifferentBooks.Add(0);
            countOfDifferentBooks.Add(3);
            this.ActAndAssert(countOfDifferentBooks, 24m);
        }
    }
}