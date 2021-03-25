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

            var actual = _target.Split(lines);

            Assert.That(actual.First().Lines, Is.EqualTo(lines));
        }

        [Test]
        public void Split_ValidListOfEightLinesWithContent_ReturnsListWithTwoContentEntry()
        {
            var linesFirst = new List<Line>()
            {
                new Line() { Text = "Test1" },
                new Line() { Text = "Test2" },
                new Line() { Text = "Test3" },
                new Line() { Text = "Test4" }
            };

            var linesSecond = new List<Line>()
            {
                new Line() { Text = "Test5" },
                new Line() { Text = "Test6" },
                new Line() { Text = "Test7" },
                new Line() { Text = "Test8" }
            };

            var all = new List<Line>();
            all.AddRange(linesFirst);
            all.AddRange(linesSecond);

            var actual = _target.Split(all);

            Assert.That(actual.First().Lines, Is.EqualTo(linesFirst));
            Assert.That(actual.Last().Lines, Is.EqualTo(linesSecond));
        }
    }
}
