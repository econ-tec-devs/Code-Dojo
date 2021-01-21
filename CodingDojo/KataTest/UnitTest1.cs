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
        public void Calculate_EmptyBasket_Return0()
        {
            var basket = new List<DishColor>();
            var expected = 0m;

            decimal actual = Sushi.Calculate(basket);

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

    public enum DishColor
    {
        Blue,
        Red,
        Yellow,
        Green,
        Gray
    }
}