using NUnit.Framework;

namespace KataTest
{
    public class SushiTests
    {
        [Test]
        public void GetPrice_InputPlates_OutputPrice()
        {
            var price = 0;
            var expected = 0;
            var actual = 0;

            actual = Sushi.GetPrice();

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}