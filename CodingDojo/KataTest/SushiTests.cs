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
        public void CalculatePrice_InputZeroDish_ReturnPrice()
        {
            var expected = 0m;

            var actual = Sushi.CalculatePrice();

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}