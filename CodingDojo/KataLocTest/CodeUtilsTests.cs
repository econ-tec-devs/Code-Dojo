// -----------------------------------------------------------------------
// <copyright file="CodeUtilsTests.cs" company="econ-tec GmbH">
//     Copyright (c) econ-tec GmbH. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------
namespace KataLocTest
{
    using KataLoc;
    using NUnit.Framework;

    public class CodeUtilsTests
    {
        private CodeUtils _target;

        [SetUp]
        public void Setup()
        {
            _target = new CodeUtils();
        }

        [TestCase(null, 0, 0)]
        [TestCase("", 0, 0)]
        [TestCase("line1", 1, 0)]
        [TestCase("line1\nline2", 2, 0)]
        [TestCase("line1\nline2\nline3\nline4", 4, 0)]
        [TestCase("line with whitespace\nanother line", 2, 0)]
        [TestCase("line1\n\nline3", 2, 1)]
        [TestCase("line1\n//\nline3", 2, 1)]
        [TestCase("line1\nline2//comment\nline3", 3, 0)]
        [TestCase("line1\n/*comment\nline3", 2, 1)]
        public void Loc_InputString_ReturnsExpected(string input, int expectedLoc, int expectedComments)
        {
            var actual = _target.Loc(input);

            Assert.That(actual.Loc, Is.EqualTo(expectedLoc));
            Assert.That(actual.Comments, Is.EqualTo(expectedComments));
        }
    }
}
