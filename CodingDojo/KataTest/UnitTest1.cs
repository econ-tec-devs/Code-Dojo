using System.Collections.Generic;
using NUnit.Framework;
using NUnit.Framework.Constraints;

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

    public class Sushi
    {
        public static decimal CalculateFullPrice(Dictionary<string, int> dishes)
        {
            return 0m;
        }
    }
}