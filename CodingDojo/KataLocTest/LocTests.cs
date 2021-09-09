using KataLOC;

namespace KataLOCTest
{
    using NUnit.Framework;

    public class LocTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Count_EmptyString_0()
        {
            var target = new LineCounter();
            var expected = 0;
            
            int actual = target.Count(string.Empty);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Count_OneLineOfCode_1()
        {
            var target = new LineCounter();
            var expected = 1;
            var text = "line1";

            int actual = target.Count(text);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}