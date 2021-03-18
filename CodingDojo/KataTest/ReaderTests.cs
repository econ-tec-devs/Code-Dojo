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
        [Test]
        public void Ctor_NewInstance_NoException()
        {
            IReader target = new Reader();

            Assert.That(target, Is.TypeOf<Reader>());
        }

        [Test]
        public void Read_EmptyFile_ReturnEmptyLines()
        {
            IReader target = new Reader();
            var fileName = "emptyFile.txt";
            var expected = 0;

            var actual = target.Read(fileName);

            Assert.That(actual.Count, Is.EqualTo(expected));
        }
    }
}
