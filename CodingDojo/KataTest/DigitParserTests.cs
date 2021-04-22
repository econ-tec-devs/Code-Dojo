using System;
using System.Collections.Generic;
using System.Text;
using KataBankOcr;
using NSubstitute;
using NUnit.Framework;

namespace KataTest
{
    [TestFixture]
    public class DigitParserTests
    {
        private DigitParser _target;
        private IRawDigitParser _rawDigitParser;

        [SetUp]
        public void Setup()
        {
            _rawDigitParser = Substitute.For<IRawDigitParser>();
            _target = new DigitParser(_rawDigitParser);
            Assert.That(_target, Is.Not.Null);
        }

        [Test]
        public void Parse_OneEntry_EmptyListOfRawDigits()
        {
            var entry = new Entry()
            {
                Lines = new List<Digit>()
                {
                    new Digit(string.Empty),
                    new Digit(string.Empty),
                    new Digit(string.Empty),
                    new Digit(string.Empty)
                }
            };

            var actual = _target.Parse(entry);

            Assert.That(actual, Is.Empty);
        }

        [Test]
        public void Parse_ListOfRawDigit_ReturnsListOfDigit()
        {
            var rawDigits = new List<RawDigit>()
            {
               new RawDigit()
            };

            //var actual = _target.Parse(rawDigits);

            //_rawDigitParser.Received(1).Parse();

            //Assert.That(actual, Is.Empty);
        }
    }
}
