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
        public void Parse_ListOfEntries_EmptyListOfRawDigits()
        {
            var entries = new List<Entry>();

            var actual = _target.Parse(entries);

            Assert.That(actual, Is.Empty);
        }
    }
}
