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

        public void ActAndAssert(decimal expected, int countOfSameBooks)
        {
            countOfDifferentBooks.Add(countOfSameBooks);
            var actual = target.Calculate(countOfDifferentBooks);
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Calculate_EmptyListWithCountOfDifferentBooks_Return0()
        {
            this.ActAndAssert(0m, 0);
        }
        
        [Test]
        public void Calculate_ListWithCountOfOneBook_Return8()
        {
            this.ActAndAssert(8m, 1);
        }
        
        [Test]
        public void Calculate_ListWithCountOfTwoSameBook_Return16()
        {
            this.ActAndAssert(16m, 2);
        }
    }
}