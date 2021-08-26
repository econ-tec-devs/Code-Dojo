using System;
using KataLoc;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace KataLocTest
{
    [TestFixture]
    public class LinesOfCodeTests
    {
        private LinesOfCode _target;

        [SetUp]
        public void SetUp()
        {
            _target = new LinesOfCode();
        }

        [Test]
        public void Count_StringInput_ReturnsZero()
        {
            var input = string.Empty;
            var expected = 0;

            var actual = _target.Count(input);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Count_StringInputNullOrWhiteSpace_ReturnsZero()
        {
            string input = null;
            var expected = 0;

            var actual = _target.Count(input);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Count_StringInputOneLineOfCode_ReturnsOne()
        {
            string input = "Console.WriteLine()";
            var expected = 1;

            var actual = _target.Count(input);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Count_StringInputTwoLinesOfCode_ReturnsTwo()
        {
            string input = "Console.WriteLine()" + Environment.NewLine + "Second Line of Code";
            var expected = 2;

            var actual = _target.Count(input);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
