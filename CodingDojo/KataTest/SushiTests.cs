using System;
using System.Collections.Generic;
using Kata;
using NUnit.Framework;

namespace KataTest
{
    public class SushiTests
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

            ActAndAssert(basket, expected);
        }

        [Test]
        public void Calculate_OneBluePlate_Return095()
        {
            var expected = 0.95m;
            var basket = new List<DishColor> { DishColor.Blue };

            ActAndAssert(basket, expected);
        }

        [Test]
        public void Calculate_OneRedPlate_Return195()
        {
            var expected = 1.95m;
            var basket = new List<DishColor> { DishColor.Red };

            ActAndAssert(basket, expected);
        }

        [Test]
        public void Calculate_OneYellowPlate_Return295()
        {
            var expected = 2.95m;
            var basket = new List<DishColor> { DishColor.Yellow };

            ActAndAssert(basket, expected);
        }

        [Test]
        public void Calculate_OneGreenPlate_Return395()
        {
            var expected = 3.95m;
            var basket = new List<DishColor> { DishColor.Green };

            ActAndAssert(basket, expected);
        }

        [Test]
        public void Calculate_OneGreyPlate_Return495()
        {
            var expected = 4.95m;
            var basket = new List<DishColor> { DishColor.Grey };

            ActAndAssert(basket, expected);
        }

        [Test]
        public void Calculate_TwoBluePlates_Return190()
        {
            var expected = 1.90m;
            var basket = new List<DishColor> { DishColor.Blue, DishColor.Blue };

            ActAndAssert(basket, expected);
        }

        [Test]
        public void Calculate_ThreeRedPlates_Return585()
        {
            var expected = 5.85m;
            var basket = new List<DishColor> { DishColor.Red, DishColor.Red, DishColor.Red };

            ActAndAssert(basket, expected);
        }

        [Test]
        public void Calculate_FiveGreyPlates_Return2475()
        {
            var expected = 24.75m;
            var basket = new List<DishColor>
            {
                DishColor.Grey, 
                DishColor.Grey, 
                DishColor.Grey, 
                DishColor.Grey, 
                DishColor.Grey
            };

            ActAndAssert(basket, expected);
        }

        [Test]
        public void Calculate_OneOfEachColor_ReturnSum2475()
        {
            var expected = 0.95m + 1.95m + 2.95m + 3.95m + 4.95m;
            var basket = new List<DishColor> { 
                DishColor.Blue, 
                DishColor.Red,
                DishColor.Yellow, 
                DishColor.Green, 
                DishColor.Grey
            };

            ActAndAssert(basket, expected);
        }

        [Test]
        public void Calculate_TwoOfEachColorAtBrunchTime_ReturnExpected()
        {
            DateTime sundayBrunchtime = new DateTime(2021, 01, 31, 12, 00, 00);
            PriceInfo expected = new PriceInfo()
            {
                Value = (0.95m + 1.95m + 2.95m + 3.95m + 4.95m) * 2,
                ToPay = 19.90m,
                Discount = 9.60m
            };
            var basket = new List<DishColor> { 
                DishColor.Blue, 
                DishColor.Blue, 
                DishColor.Red,
                DishColor.Red,
                DishColor.Yellow, 
                DishColor.Yellow, 
                DishColor.Green, 
                DishColor.Green, 
                DishColor.Grey,
                DishColor.Grey
            };

            PriceInfo actual = Sushi.Calculate(basket, sundayBrunchtime);

            Assert.That(actual.Value, Is.EqualTo(expected.Value));
            Assert.That(actual.ToPay, Is.EqualTo(expected.ToPay));
            Assert.That(actual.Discount, Is.EqualTo(expected.Discount));
        }

        private static void ActAndAssert(List<DishColor> basket, decimal expected)
        {
            var actual = Sushi.Calculate(basket);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}