using System.Collections.Generic;
using NUnit.Framework;

namespace KataTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Calculate_NoDish_ReturnNothing()
        {
            Dictionary<string, int> dishes = new Dictionary<string, int>();
            var expected = 0;
            
            var actual = Sushi.CalculateFullPrice(dishes);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}