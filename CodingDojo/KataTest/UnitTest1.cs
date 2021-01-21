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
        public void Calculate_InputZeroPlate_Return0()
        {
            var expected = 0m;
            var basket = new List<DishColor>();

            var actual = Sushi.Calculate(basket);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}