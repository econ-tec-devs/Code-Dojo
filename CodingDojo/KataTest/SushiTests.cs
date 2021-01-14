using System.Collections.Generic;
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
        public void CalculateFullPrice_NoDish_ReturnNothing()
        {
            var expected = 0;
            
            var actual = Sushi.CalculateFullPrice(dishes);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void CalculateFullPrice_OneBlueDish_Return095()
        {
            dishes.Add("blue", 1);
            var expected = 0.95m;
            
            var actual = Sushi.CalculateFullPrice(dishes);

            Assert.That(actual, Is.EqualTo(expected));
        }
        
        [Test]
        public void CalculateFullPrice_TwoBlueDish_Return190()
        {
            dishes.Add("blue", 2);
            var expected = 1.90m;
            
            var actual = Sushi.CalculateFullPrice(dishes);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}