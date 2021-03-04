// -----------------------------------------------------------------------
// <copyright file="BankOcrTests.cs" company="econ-tec GmbH">
//     Copyright (c) econ-tec GmbH. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------
namespace KataTest
{
    using Kata;
    using NSubstitute;
    using NUnit.Framework;

    public class BankOcrTests
    {
        private BankOcr _target;

        [SetUp]
        public void Setup()
        {
            _target = new BankOcr();
        }

        [Test]
        public void Ctor_None_NewInstanceNoException()
        {
            Assert.That(_target, Is.TypeOf<BankOcr>());
        }

        [Test]
        public void Ctor_InjectReader_NoError()
        {
            var reader = Substitute.For<IReader>();

            var target = new BankOcr(reader);

            Assert.That(target, Is.TypeOf<BankOcr>());
        }

        [Test]
        public void Ctor_InjectReaderAndLineSplitter_NoError()
        {
            var reader = Substitute.For<IReader>();
            var lineSplitter = Substitute.For<ILineSplitter>();

            var target = new BankOcr(reader, lineSplitter);

            Assert.That(target, Is.TypeOf<BankOcr>());
        }

        [Test]
        public void Ctor_InjectReaderLineSplitterAndEntryParser_NoError()
        {
            var reader = Substitute.For<IReader>();
            var lineSplitter = Substitute.For<ILineSplitter>();
            var entryParser = Substitute.For<IEntryParser>();

            var target = new BankOcr(reader, lineSplitter, entryParser);

            Assert.That(target, Is.TypeOf<BankOcr>());
        }

        [Test]
        public void ScanFile_InputFileName_ReturnAccountNumbers()
        {
            var fileName = "emptyfile.txt";
            var expected = 0;

            var actual = _target.ScanFile(fileName);

            Assert.That(actual.Count, Is.EqualTo(expected));
        }
    }
}
