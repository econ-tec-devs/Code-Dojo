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
            var fileName = "emptyfile.txt";
            var expected = 0;

            var actual = _target.ScanFile(fileName);

            Assert.That(actual.Count, Is.EqualTo(expected));
        }

        [Test]
        public void ScanFile_CallFileReader_ReadWasCalledWithFilename()
        {
            var fileName = "emptyfile.txt";

            _target.ScanFile(fileName);
        
            reader.Received(1).Read(fileName);
        }
    }
}
