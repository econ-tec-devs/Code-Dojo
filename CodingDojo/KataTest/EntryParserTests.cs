using System.Collections.Generic;
using System.Text;
using KataBankOcr;
using KataBankOcr.Interfaces;
using NSubstitute;
using NUnit.Framework;

namespace KataTest
{
    [TestFixture]
    class EntryParserTests
    {
        [Test]
        public void Ctor_InjectDigitParser_ReturnsNoError()
        {
            var digitParser = Substitute.For<IDigitParser>();
            IEntryParser target = new EntryParser(digitParser);

            Assert.That(target, Is.Not.Null);
        }
        
        [Test]
        public void Parse_ListOfEntries_EmptyListOfRawDigits()
        {
            var digitParser = Substitute.For<IDigitParser>();
            IEntryParser target = new EntryParser(digitParser);
            
            List<Entry> entries = new List<Entry>();
            var actual = target.Parse(entries);

            Assert.That(actual, Is.Empty);
        }
    }
}
