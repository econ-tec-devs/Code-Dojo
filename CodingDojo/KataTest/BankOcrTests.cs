// -----------------------------------------------------------------------
// <copyright file="BankOcrTests.cs" company="econ-tec GmbH">
//     Copyright (c) econ-tec GmbH. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------
namespace KataTest
{
    using System.Collections.Generic;
    using Kata;
    using NSubstitute;
    using NUnit.Framework;

    public class BankOcrTests
    {
        private BankOcr _target;
        private IEntryParser entryParser;
        private ILineSplitter lineSplitter;
        private IReader reader;

        [SetUp]
        public void Setup()
        {
            reader = Substitute.For<IReader>();
            lineSplitter = Substitute.For<ILineSplitter>();
            entryParser = Substitute.For<IEntryParser>();
            _target = new BankOcr(this.reader, this.lineSplitter, this.entryParser);
        }

        [Test]
        public void Ctor_None_NewInstanceNoException()
        {
            Assert.That(_target, Is.TypeOf<BankOcr>());
        }

        [Test]
        public void ScanFile_InputFileName_ReturnAccountNumbers()
        {
            var fileName = "emptyFile.txt";
            var expected = 0;
            var accountNumbers = new List<AccountNumber>();
            this.entryParser.Parse(null).ReturnsForAnyArgs(accountNumbers);

            var actual = _target.ScanFile(fileName);

            Assert.That(actual.Count, Is.EqualTo(expected));
        }

        [Test]
        public void ScanFile_CallFileReader_ReadWasCalledWithFilename()
        {
            var fileName = "emptyFile.txt";

            _target.ScanFile(fileName);

            reader.Received(1).Read(fileName);
        }

        [Test]
        public void ScanFile_CallLineSplitter_SplitWasCalledWithLines()
        {
            var fileName = "emptyFile.txt";
            var lines = new List<string>();
            this.reader.Read(fileName).Returns(lines);

            _target.ScanFile(fileName);

            this.lineSplitter.Received(1).Split(lines);
        }

        [Test]
        public void ScanFile_CallEntryParser_ParseWasCalledWithEntries()
        {
            var fileName = "emptyFile.txt";
            var entries = new List<Entry>();
            var lines = new List<string>();
            this.reader.Read(fileName).Returns(lines);
            this.lineSplitter.Split(lines).Returns(entries);

            _target.ScanFile(fileName);

            this.entryParser.Received(1).Parse(entries);
        }

        [Test]
        public void ScanFile_CallEntryParser_ReturnsAccountNumbers()
        {
            var fileName = "emptyFile.txt";
            var entries = new List<Entry>();
            var lines = new List<string>();
            var accountNumbers = new List<AccountNumber>();
            this.reader.Read(fileName).Returns(lines);
            this.lineSplitter.Split(lines).Returns(entries);
            this.entryParser.Parse(entries).Returns(accountNumbers);

            var actual = _target.ScanFile(fileName);
            Assert.That(actual, Is.EqualTo(accountNumbers));
        }
    }
}
