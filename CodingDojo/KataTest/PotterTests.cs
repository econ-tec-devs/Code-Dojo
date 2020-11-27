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

        [Test]
        public void Calculate_EmptyListWithCountOfDifferentBooks_Return0()
        {
            this.ActAndAssert(0, 0m);
        }
        
        [Test]
        public void Calculate_ListWithCountOfOneBook_Return8()
        {
            this.ActAndAssert(1, 8m);
        }
        
        [Test]
        public void Calculate_ListWithCountOfTwoSameBook_Return16()
        {
            this.ActAndAssert(2, 16m);
        }
        
        [Test]
        public void Calculate_ListWithCountOfThreeSameBook_Return24()
        {
            this.ActAndAssert(3,24m);
        }
        
        [Test]
        public void Calculate_ListWithCountOfFourSameBook_Return32()
        {
            this.ActAndAssert(4, 32m);
        }
        
        [Test]
        public void Calculate_ListWithCountOfTenSameBook_Return80()
        {
            this.ActAndAssert(10, 80m);
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