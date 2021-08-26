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
            _target = new Loc();
        }

        private Loc _target;

        [Test]
        public void LineOfCode_EmptyCode_ReturnsZero()
        {
            var expected = new LinesCount { CommentsWhitespaceLineCount = 0, LineOfCodeCount = 0 };
            var actual = _target.LineOfCode(string.Empty);

            Assert.That(actual.CommentsWhitespaceLineCount, Is.EqualTo(expected.CommentsWhitespaceLineCount));
            Assert.That(actual.LineOfCodeCount, Is.EqualTo(expected.LineOfCodeCount));
        }

        [Test]
        public void LineOfCode_OneLineOfCode_ReturnOneLineCount()
        {
            var text = "Console.WriteLine()";
            var expected = new LinesCount { CommentsWhitespaceLineCount = 0, LineOfCodeCount = 1 };

            var actual = _target.LineOfCode(text);

            Assert.That(actual.CommentsWhitespaceLineCount, Is.EqualTo(expected.CommentsWhitespaceLineCount));
            Assert.That(actual.LineOfCodeCount, Is.EqualTo(expected.LineOfCodeCount));
        }

        [Test]
        public void LineOfCode_TwoLineOfCode_ReturnTwoLineCount()
        {
            var text = "Console.WriteLine()" + Environment.NewLine + "Bla";
            var expected = new LinesCount { CommentsWhitespaceLineCount = 0, LineOfCodeCount = 2 };

            var actual = _target.LineOfCode(text);

            Assert.That(actual.CommentsWhitespaceLineCount, Is.EqualTo(expected.CommentsWhitespaceLineCount));
            Assert.That(actual.LineOfCodeCount, Is.EqualTo(expected.LineOfCodeCount));
        }

        [Test]
        public void LineOfCode_OneLineOfCodeAndOneLineComments_ReturnOneLineCount()
        {
            var text = "Console.WriteLine()" + Environment.NewLine + "//";
            var expected = new LinesCount { CommentsWhitespaceLineCount = 0, LineOfCodeCount = 1 };

            var actual = _target.LineOfCode(text);

            Assert.That(actual.CommentsWhitespaceLineCount, Is.EqualTo(expected.CommentsWhitespaceLineCount));
            Assert.That(actual.LineOfCodeCount, Is.EqualTo(expected.LineOfCodeCount));
        }

        [Test]
        public void LineOfCode_TwoLineOfCodeAndTwoLineComments_ReturnTwoLineCount()
        {
            var text = "Console.WriteLine()" + Environment.NewLine + "//" + Environment.NewLine + "Bla" + Environment.NewLine + "//";
            var expected = new LinesCount { CommentsWhitespaceLineCount = 0, LineOfCodeCount = 2 };

            var actual = _target.LineOfCode(text);

            Assert.That(actual.CommentsWhitespaceLineCount, Is.EqualTo(expected.CommentsWhitespaceLineCount));
            Assert.That(actual.LineOfCodeCount, Is.EqualTo(expected.LineOfCodeCount));
        }

        [TestCase("Bla", "//", 1)]
        [TestCase("Bla", "/**/", 1)]
        [TestCase("Bla", "/**/ Bla", 2)]
        [TestCase("Bla\r\n Bla", "/**/ Bla", 3)]
        [TestCase("Bla\r\n Bla\r\n/*ddd*/", "/**/ Bla", 3)]
        [TestCase("Bla\r\n Bla\r\n/*ddd*/ Bla", "/**/ Bla", 4)]
        public void LineOfCode_InputCodeAndInputComment_ReturnCodeCount(string code, string comment, int codeCount)
        {
            var text = code + Environment.NewLine + comment;
            var expected = new LinesCount { CommentsWhitespaceLineCount = 0, LineOfCodeCount = codeCount };

            var actual = _target.LineOfCode(text);

            Assert.That(actual.CommentsWhitespaceLineCount, Is.EqualTo(expected.CommentsWhitespaceLineCount));
            Assert.That(actual.LineOfCodeCount, Is.EqualTo(expected.LineOfCodeCount));
        }

        [Test]
        public void LineOfCode_ThreeCodeLinesWithInlineComment_ReturnThreeLineCount()
        {
            var text = "/*as*/ Console.WriteLine()" + Environment.NewLine + "/* sdsd */ lalala" + Environment.NewLine + "Bla" + Environment.NewLine + "//";
            var expected = new LinesCount { CommentsWhitespaceLineCount = 0, LineOfCodeCount = 3 };

            var actual = _target.LineOfCode(text);

            Assert.That(actual.CommentsWhitespaceLineCount, Is.EqualTo(expected.CommentsWhitespaceLineCount));
            Assert.That(actual.LineOfCodeCount, Is.EqualTo(expected.LineOfCodeCount));
        }
    }
}
