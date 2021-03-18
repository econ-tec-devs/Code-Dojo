// -----------------------------------------------------------------------
// <copyright file="ReaderTests.cs" company="econ-tec GmbH">
//     Copyright (c) econ-tec GmbH. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------
namespace KataTest
{
    using Kata;
    using NUnit.Framework;

    public class ReaderTests
    {
        private IReader target;

        [SetUp]
        public void Setup()
        {
            this.target = new Reader();
        }

        [Test]
        public void Ctor_NewInstance_NoException()
        {
            Assert.That(this.target, Is.TypeOf<Reader>());
        }

        [Test]
        public void Read_EmptyFile_ReturnEmptyLines()
        {
            var fileName = "emptyFile.txt";
            var expected = 0;

            var actual = this.target.Read(fileName);

            Assert.That(actual.Count, Is.EqualTo(expected));
        }

        [Test]
        public void Read_FileWithTenLines_ReturnTenLines()
        {
            var fullPath = "fileWithTenLines.txt";
            var expected = 10;

            var actual = this.target.Read(fullPath);

            Assert.That(actual.Count, Is.EqualTo(expected));
        }
    }
}
