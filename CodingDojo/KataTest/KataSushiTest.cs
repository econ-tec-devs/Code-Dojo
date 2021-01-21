using System.Collections.Generic;
using NUnit.Framework;

namespace KataTest
{
    public class KataSushiTest
    {
        private List<DishColor> basket ;

        [SetUp]
        public void Setup()
        {
            basket = new List<DishColor>();
        }

        [Test]
        public void Calculate_EmptyBasket_Return0()
        { 
            var expected = 0m;

            decimal actual = Sushi.Calculate(basket);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Calculate_OneBlue_Return095()
        {
            basket.Add(DishColor.Blue);
            var expected = 0.95m;

            decimal actual = Sushi.Calculate(basket);

            Assert.That(actual, Is.EqualTo(expected));
        }
        
        [Test]
        public void Calculate_OneRed_Return195()
        {
            basket.Add(DishColor.Red);
            var expected = 1.95m;

            decimal actual = Sushi.Calculate(basket);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Calculate_OneYellow_Return295()
        {
            basket.Add(DishColor.Red);
            var expected = 2.95m;

            decimal actual = Sushi.Calculate(basket);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}