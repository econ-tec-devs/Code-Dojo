using System.Collections.Generic;
using KataPotter;
using NUnit.Framework;

namespace KataTest
{
    public class PotterTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Calculate_EmptyListWithCountOfDifferentBooks_Return0()
        {
            var target = new Potter();
            var countOfDifferentBooks = new List<int>();
            var expected = 0m;
            
            decimal actual = target.Calculate(countOfDifferentBooks);

            Assert.That(actual, Is.EqualTo(expected));
        }
        
        [Test]
        public void Calculate_ListWithCountOfOneBook_Return8()
        {
            var target = new Potter();
            var countOfDifferentBooks = new List<int>();
            countOfDifferentBooks.Add(1);
            var expected = 8m;
            
            decimal actual = target.Calculate(countOfDifferentBooks);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}