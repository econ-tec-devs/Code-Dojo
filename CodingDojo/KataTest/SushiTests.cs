using System.Collections.Generic;
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
        public void CalculateFullPrice_NoDish_ReturnNothing()
        {
            Dictionary<string, int> dishes = new Dictionary<string, int>();
            var expected = 0;
            
            var actual = Sushi.CalculateFullPrice(dishes);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void CalculateFullPrice_OneBlueDish_Return095()
        {
            Dictionary<string, int> dishes = new Dictionary<string, int>() { {"blue", 1} };
            var expected = 0.95m;
            
            var actual = Sushi.CalculateFullPrice(dishes);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}