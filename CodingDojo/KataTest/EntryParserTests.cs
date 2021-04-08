// -----------------------------------------------------------------------
// <copyright file="EntryParserTests.cs" company="econ-tec GmbH">
//     Copyright (c) econ-tec GmbH. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

using KataBankOcr;
using KataBankOcr.Interfaces;

namespace KataTest
{
    using NSubstitute;
    using NUnit.Framework;

    public class EntryParserTests
    {
        private IDigitParser _digitParser;
        private IAccountNumberBuilder _accountNumberBuilder;

        [SetUp]
        public void SetUp()
        {
            _digitParser = Substitute.For<IDigitParser>();
            _accountNumberBuilder = Substitute.For<IAccountNumberBuilder>();
        }

        [Test]
        public void Ctor_DigitParser_NoError()
        {
            IEntryParser target = new EntryParser(_digitParser);
        }

        [Test]
        public void Ctor_AccountNumberBuilder_NoError()
        {
            IEntryParser target = new EntryParser(_digitParser, _accountNumberBuilder);
        }

        //[Test]
        //public void Parse_EmptyListOfEntries_EmptyListOfAccountNumber()
        //{
        //    var emptyList = new List<Entry>();

        //    var actual = _entryParser.Parse(emptyList);

        //    Assert.That(actual, Is.Empty);
        //}
    }
}
