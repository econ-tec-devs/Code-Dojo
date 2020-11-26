using System.Collections.Generic;
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
    }

    public class Potter
    {
        public decimal Calculate(List<int> countOfDifferentBooks)
        {
            return 0;
        }
    }
}