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
            var actual = Sushi.CalculatePrice();

            var expected = 0m;

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}