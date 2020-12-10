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
        public void CalculatePrice_NoDish_ReturnFullPrice()
        {
            var dishes = new Dictionary<string, int>();

            var expected = 0;

            var actual = Sushi.CalculatePrice(dishes);


            Assert.That(actual,Is.EqualTo(expected));
        }
    }

    public class Sushi
    {
        public static decimal CalculatePrice(Dictionary<string, int> dishes)
        {
            return 0;
        }
    }
}