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
        public void CalculatePrice_NoDish_ReturnFullPrice()
        {
            var dishes = new Dictionary<string, int>();

            var expected = 0;

            var actual = Sushi.CalculatePrice(dishes);


            Assert.That(actual,Is.EqualTo(expected));
        }
    }
}