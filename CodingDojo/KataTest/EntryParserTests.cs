// -----------------------------------------------------------------------
// <copyright file="EntryParserTests.cs" company="econ-tec GmbH">
//     Copyright (c) econ-tec GmbH. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------
namespace KataTest
{
    using System.Collections.Generic;
    using KataBankOcr;
    using KataBankOcr.Interfaces;
    using NSubstitute;
    using NUnit.Framework;

    public class EntryParserTests
    {
        private readonly int _twoAccountNumbers = 2;
        private IAccountNumberBuilder _accountNumberBuilder;
        private IDigitParser _digitParser;
        private IEntryParser _target;

        [SetUp]
        public void SetUp()
        {
            _digitParser = Substitute.For<IDigitParser>();
            _accountNumberBuilder = Substitute.For<IAccountNumberBuilder>();
            _target = new EntryParser(_digitParser, _accountNumberBuilder);
        }

        [Test]
        public void Ctor_InjectAllDependencies_AllDependenciesWereInjected()
        {
            IEntryParser target = new EntryParser(_digitParser, _accountNumberBuilder);
        }

        [Test]
        public void Parse_EmptyListOfEntries_EmptyListOfAccountNumber()
        {
            var emptyList = new List<Entry>();

            var actual = _target.Parse(emptyList);

            Assert.That(actual, Is.Empty);
        }

        [Test]
        public void Parse_ListWithTwoEntries_ListWithTwoAccountNumbers()
        {
            var entries = new List<Entry>();
            var lines = new List<Line> { new Line(), new Line(), new Line(), new Line() };
            var entry = new Entry { Lines = lines };
            entries.Add(entry);
            entries.Add(entry);

            var expected = _twoAccountNumbers;

            var actual = _target.Parse(entries);

            Assert.That(actual.Count, Is.EqualTo(expected));
        }

        [Test]
        public void Parse_EmptyEntry_EmptyAccountNumber()
        {
            var entry = new Entry();

            var actual = _target.Parse(entry);

            Assert.That(actual.Value, Is.EqualTo(string.Empty));
        }

        [Test]
        public void Parse_EmptyEntry_digitWasCalledOneTime()
        {
            var entry = new Entry();

            _target.Parse(entry);

            _digitParser.Received(1).Parse(Arg.Any<RawDigit>());
        }
    }
}
