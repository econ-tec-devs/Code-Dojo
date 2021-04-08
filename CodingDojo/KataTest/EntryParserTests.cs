// -----------------------------------------------------------------------
// <copyright file="EntryParserTests.cs" company="econ-tec GmbH">
//     Copyright (c) econ-tec GmbH. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

using System.Collections.Generic;
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
        private IEntryParser _target;

        [SetUp]
        public void SetUp()
        {
            _digitParser = Substitute.For<IDigitParser>();
            _accountNumberBuilder = Substitute.For<IAccountNumberBuilder>();
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
    }
}
