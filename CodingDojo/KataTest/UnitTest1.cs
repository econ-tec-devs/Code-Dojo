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

    public class Sushi
    {
        public static decimal Calculate(List<DishColor> basket)
        {
            return 0m;
        }
    }

    public class DishColor
    {
    }
}