// -----------------------------------------------------------------------
// <copyright file="EntryParserTests.cs" company="econ-tec GmbH">
//     Copyright (c) econ-tec GmbH. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------
namespace KataTest
{
    using NSubstitute;
    using NUnit.Framework;

    public class EntryParserTests
    {
        private IDigitParser _digitParser;

        [SetUp]
        public void SetUp()
        {
            _digitParser = Substitute.For<IDigitParser>();
        }

        [Test]
        public void Ctor_DigitParser_NoError()
        {
            new EntryParser(_digitParser);
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
