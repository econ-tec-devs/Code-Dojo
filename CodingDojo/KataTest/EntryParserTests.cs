using System.Collections.Generic;
using KataBankOcr;
using KataBankOcr.Interfaces;
using NSubstitute;
using NUnit.Framework;

namespace KataTest
{
    [TestFixture]
    class EntryParserTests
    {
        private IDigitParser _digitParser;
        private IEntryParser _target;

        [SetUp]
        public void Setup()
        {
            _digitParser = Substitute.For<IDigitParser>();
            _target = new EntryParser(_digitParser);
            Assert.That(_target, Is.Not.Null);
        }

        [Test]
        public void Parse_ListOfEntries_EmptyListOfAccountNumbers()
        {
            var entries = new List<Entry>();

            var actual = _target.Parse(entries);

            Assert.That(actual, Is.Empty);
        }

        [Test]
        public void Parse_ListOfEntriesWith1Entry_ListWithOneAccountNumber()
        {
            var entry = new Entry();
            var entries = new List<Entry>
            {
                entry
            };

            var actual = _target.Parse(entries);

            Assert.That(actual, Is.Not.Empty);
            Assert.That(actual.Count, Is.EqualTo(1));
        }

        [Test]
        public void Parse_ListOfEntriesWith2Entry_ListWithTwoAccountNumber()
        {
            var entry = new Entry();
            var entries = new List<Entry>
            {
                entry, entry
            };

            var actual = _target.Parse(entries);

            Assert.That(actual, Is.Not.Empty);
            Assert.That(actual.Count, Is.EqualTo(2));
        }

        [Test]
        public void Parse_OneEntry_ListWithRawDigits()
        {
            var entry = new Entry()
            {
                Lines = new List<Line>()
                {
                    new Line(string.Empty)
                }
            };


            List<RawDigit> actual = _target.Parse(entry);

            Assert.That(actual, Is.Not.Empty);
            Assert.That(actual.Count, Is.EqualTo(2));
        }
    }
}
