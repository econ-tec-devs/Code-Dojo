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
        public void Calculate_OneBlueDishOnMonday_ReturnSum095()
        {
            var expected = 0.95m;
            var basket = new List<DishColor>
            {
                DishColor.Blue
            };
            
            var actual = Sushi.Calculate(basket, new DateTime(2021, 1, 18, 13, 00, 00));

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Calculate_OneRedDishOnMonday_ReturnSum195()
        {
            var expected = 1.95m;
            var basket = new List<DishColor>
            {
                DishColor.Red
            };
            
            var actual = Sushi.Calculate(basket, new DateTime(2021, 1, 18, 13, 00, 00));

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Calculate_OneYellowDishOnMonday_ReturnSum295()
        {
            var expected = 2.95m;
            var basket = new List<DishColor>
            {
                DishColor.Yellow
            };
            
            var actual = Sushi.Calculate(basket, new DateTime(2021, 1, 18, 13, 00, 00));

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Calculate_OneGreenDishOnMonday_ReturnSum395()
        {
            var expected = 3.95m;
            var basket = new List<DishColor>
            {
                DishColor.Green
            };
            
            var actual = Sushi.Calculate(basket, new DateTime(2021, 1, 18, 13, 00, 00));

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Calculate_OneGreyDishOnMonday_ReturnSum495()
        {
            var expected = 4.95m;
            var basket = new List<DishColor>
            {
                DishColor.Grey
            };
            
            var actual = Sushi.Calculate(basket, new DateTime(2021, 1, 18, 13, 00, 00));

            Assert.That(actual, Is.EqualTo(expected));
        }
        
        [Test]
        public void Calculate_OneBlueDishOnSunday1600_ReturnSum095()
        {
            var expected = 0.95m;
            var basket = new List<DishColor>
            {
                DishColor.Blue
            };

            var actual = Sushi.Calculate(basket, new DateTime(2021, 1, 17, 16, 00, 00));

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Calculate_OneBlueDishOnSunday1400_ReturnSum1990()
        {
            var expected = 19.90m;
            var basket = new List<DishColor>
            {
                DishColor.Blue
            };

            var actual = Sushi.Calculate(basket, new DateTime(2021, 1, 17, 14, 00, 00));

            Assert.That(actual, Is.EqualTo(expected));
        }
        
        [Test]
        public void Calculate_OneBlueDishOnSunday1500_ReturnSum1990()
        {
            var expected = 19.90m;
            var basket = new List<DishColor>
            {
                DishColor.Blue
            };

            ActAndAssert(basket, expected, new DateTime(2021, 1, 17, 15, 00, 00));
        }

        [Test]
        private static void ActAndAssert(List<DishColor> basket, decimal expected, DateTime timeOfPayment)
        {
            var actual = Sushi.Calculate(basket, timeOfPayment);

            Assert.That(actual, Is.EqualTo(expected));
        }
       private static void ActAndAssert(List<DishColor> basket, decimal expected)
        {
            var actual = Sushi.Calculate(basket);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}