// -----------------------------------------------------------------------
// <copyright file="LineSplitterTests.cs" company="econ-tec GmbH">
//     Copyright (c) econ-tec GmbH. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------
namespace KataTest
{
    using System.Collections.Generic;
    using System.Linq;
    using KataBankOcr;
    using KataBankOcr.Interfaces;
    using NUnit.Framework;

    [TestFixture]
    public class LineSplitterTests
    {
        [SetUp]
        public void SetUp()
        {
            _target = new LineSplitter();
        }

        private ILineSplitter _target;

        [Test]
        public void Split_ValidListOfFourLine_ReturnsListWithOneEntry()
        {
            var lines = new List<Line>()
            {
                new Line(),
                new Line(),
                new Line(),
                new Line()
            };
            var expected = 1;

            var actual = _target.Split(lines);

            Assert.That(actual, Is.TypeOf<List<Entry>>());
            Assert.That(actual.Count, Is.EqualTo(expected));
        }

        [Test]
        public void Split_EmptyListOfLine_ReturnsEmptyListOfEntry()
        {
            var lines = new List<Line>();

            var actual = _target.Split(lines);

            Assert.That(actual.Any(), Is.False);
        }

        [Test]
        public void Split_ValidListOfEightLine_ReturnsListWithTwoEntries()
        {
            var lines = new List<Line>()
            {
                new Line(),
                new Line(),
                new Line(),
                new Line(),
                new Line(),
                new Line(),
                new Line(),
                new Line()
            };
            var expected = 2;

            var actual = _target.Split(lines);

            Assert.That(actual, Is.TypeOf<List<Entry>>());
            Assert.That(actual.Count, Is.EqualTo(expected));
        }

        [Test]
        public void Split_ValidListOfFourLinesWithContent_ReturnsListWithContentEntry()
        {
            var lines = new List<Line>()
            {
                new Line() { Text = "Test1" },
                new Line() { Text = "Test2" },
                new Line() { Text = "Test3" },
                new Line() { Text = "Test4" }
            };
            var expected1 = "Test1";
            var expected2 = "Test2";
            var expected3 = "Test3";
            var expected4 = "Test4";

            var actual = _target.Split(lines);

            Assert.That(actual.First().Lines[0].Text, Is.EqualTo(expected1));
            Assert.That(actual.First().Lines[1].Text, Is.EqualTo(expected2));
            Assert.That(actual.First().Lines[2].Text, Is.EqualTo(expected3));
            Assert.That(actual.First().Lines[3].Text, Is.EqualTo(expected4));
        }
    }
}
