using System;
using System.Collections.Generic;
using System.Text;
using KataBankOcr;
using NUnit.Framework;

namespace KataTest
{
    [TestFixture]
    public class DigitParserTests
    {
        private DigitParser _target;

        [SetUp]
        public void Setup()
        {
            _target = new DigitParser();
            Assert.That(_target, Is.Not.Null);
        }

        [Test]
        public void Parse_OneEntry_EmptyListOfRawDigits()
        {
            var entry = new Entry()
            {
                Lines = new List<Line>()
                {
                    new Line(string.Empty),
                    new Line(string.Empty),
                    new Line(string.Empty),
                    new Line(string.Empty)
                }
            };
            
            var actual = _target.Parse(entry);

            Assert.That(actual, Is.Empty);
        }
    }
}
