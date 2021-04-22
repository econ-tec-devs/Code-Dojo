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
            var lines = new List<Digit>()
            {
                new Digit(""),
                new Digit(""),
                new Digit(""),
                new Digit("")
            };
            var expected = 1;

            var actual = _target.Split(lines);

            Assert.That(actual, Is.TypeOf<List<Entry>>());
            Assert.That(actual.Count, Is.EqualTo(expected));
        }

        [Test]
        public void Split_EmptyListOfLine_ReturnsEmptyListOfEntry()
        {
            var lines = new List<Digit>();

            var actual = _target.Split(lines);

            Assert.That(actual.Any(), Is.False);
        }

        [Test]
        public void Split_ValidListOfEightLine_ReturnsListWithTwoEntries()
        {
            var lines = new List<Digit>()
            {
                new Digit(""),
                new Digit(""),
                new Digit(""),
                new Digit(""),
                new Digit(""),
                new Digit(""),
                new Digit(""),
                new Digit("")
            };
            var expected = 2;

            var actual = _target.Split(lines);

            Assert.That(actual, Is.TypeOf<List<Entry>>());
            Assert.That(actual.Count, Is.EqualTo(expected));
        }

        [Test]
        public void Split_ValidListOfFourLinesWithContent_ReturnsListWithContentEntry()
        {
            var lines = new List<Digit>()
            {
                new Digit("") { Text = "Test1" },
                new Digit("") { Text = "Test2" },
                new Digit("") { Text = "Test3" },
                new Digit("") { Text = "Test4" }
            };

            var actual = _target.Split(lines);

            Assert.That(actual.First().Lines, Is.EqualTo(lines));
        }

        [Test]
        public void Split_ValidListOfEightLinesWithContent_ReturnsListWithTwoContentEntry()
        {
            var linesFirst = new List<Digit>()
            {
                new Digit("") { Text = "Test1" },
                new Digit("") { Text = "Test2" },
                new Digit("") { Text = "Test3" },
                new Digit("") { Text = "Test4" }
            };

            var linesSecond = new List<Digit>()
            {
                new Digit("") { Text = "Test5" },
                new Digit("") { Text = "Test6" },
                new Digit("") { Text = "Test7" },
                new Digit("") { Text = "Test8" }
            };

            var all = new List<Digit>();
            all.AddRange(linesFirst);
            all.AddRange(linesSecond);

            var actual = _target.Split(all);

            Assert.That(actual.First().Lines, Is.EqualTo(linesFirst));
            Assert.That(actual.Last().Lines, Is.EqualTo(linesSecond));
        }
    }
}
