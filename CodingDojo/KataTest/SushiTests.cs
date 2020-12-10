using System.Collections.Generic;
using KataSushi;
using NUnit.Framework;

namespace KataTest
{
    public class SushiTests
    {
        private Dictionary<string, int> dishes;

        [SetUp]
        public void Setup()
        {
            dishes = new Dictionary<string, int>();
        }

        [Test]
        public void CalculatePrice_NoDish_ReturnFullPrice()
        {
            var expected = 0;
            
            ActAndAssert(dishes, expected);
        } 
        
        [Test]
        public void CalculatePrice_OneBlueDish_Return095()
        {
            this.dishes.Add("blue", 1);
            var expected = 0.95m;
            
            ActAndAssert(dishes, expected);
        }
        
        [Test]
        public void CalculatePrice_TwoBlueDish_Return190()
        {
            this.dishes.Add("blue", 2);
            var expected = 1.90m;
            
            ActAndAssert(dishes, expected);
        }
        
        [Test]
        public void CalculatePrice_ThreeBlueDish_Return285()
        {
            this.dishes.Add("blue", 3);
            var expected = 2.85m;
            
            ActAndAssert(dishes, expected);
        }
        
        [Test]
        public void CalculatePrice_OneRedDish_Return()
        {
            this.dishes.Add("red", 1);
            var expected = 1.95m;
            
            ActAndAssert(dishes, expected);
        }

        private void ActAndAssert(Dictionary<string, int> dictionary, decimal expected)
        {
            var actual = Sushi.CalculatePrice(dishes);
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}