using System.Collections.Generic;
using KataSushi;
using NUnit.Framework;
using NUnit.Framework.Constraints;

namespace KataTest
{
    public class SushiTests
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
        
        [Test]
        public void CalculatePrice_OneBlueDish_Return095()
        {
            var dishes = new Dictionary<string, int>();
            dishes.Add("blue", 1);

            var expected = 0.95m;


            var actual = Sushi.CalculatePrice(dishes);


            Assert.That(actual,Is.EqualTo(expected));
        }
    }
}