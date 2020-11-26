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

        [Test]
        public void Calculate_EmptyListWithCountOfDifferentBooks_Return0()
        {
            var expected = 0m;
            
            decimal actual = target.Calculate(countOfDifferentBooks);

            Assert.That(actual, Is.EqualTo(expected));
        }
        
        [Test]
        public void Calculate_ListWithCountOfOneBook_Return8()
        {
            countOfDifferentBooks.Add(1);
            var expected = 8m;
            
            decimal actual = target.Calculate(countOfDifferentBooks);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}