// -----------------------------------------------------------------------
// <copyright file="LocTests.cs" company="econ-tec GmbH">
//     Copyright (c) econ-tec GmbH. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------
namespace KataLocTest
{
    using System;
    using KataLOC;
    using NUnit.Framework;

    [TestFixture]
    public class LocTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void LineOfCode_EmptyCode_ReturnsZero()
        {
            var expected = new LinesCount { CommentsWhitespaceLineCount = 0, LineOfCodeCount = 0 };
            var actual = Loc.LineOfCode(string.Empty);

            Assert.That(actual.CommentsWhitespaceLineCount, Is.EqualTo(expected.CommentsWhitespaceLineCount));
            Assert.That(actual.LineOfCodeCount, Is.EqualTo(expected.LineOfCodeCount));
        }

        [Test]
        public void LineOfCode_OneLineOfCode_ReturnOneLineCount()
        {
            var text = "Console.WriteLine()";
            var expected = new LinesCount { CommentsWhitespaceLineCount = 0, LineOfCodeCount = 1 };

            var actual = Loc.LineOfCode(text);

            Assert.That(actual.CommentsWhitespaceLineCount, Is.EqualTo(expected.CommentsWhitespaceLineCount));
            Assert.That(actual.LineOfCodeCount, Is.EqualTo(expected.LineOfCodeCount));
        }

        [Test]
        public void LineOfCode_TwoLineOfCode_ReturnTwoLineCount()
        {
            var text = "Console.WriteLine()" + Environment.NewLine + "Bla";
            var expected = new LinesCount { CommentsWhitespaceLineCount = 0, LineOfCodeCount = 2 };

            var actual = Loc.LineOfCode(text);

            Assert.That(actual.CommentsWhitespaceLineCount, Is.EqualTo(expected.CommentsWhitespaceLineCount));
            Assert.That(actual.LineOfCodeCount, Is.EqualTo(expected.LineOfCodeCount));
        }
    }
}
