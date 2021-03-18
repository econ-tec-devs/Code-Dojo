using System.Collections.Generic;
using KataBankOcr;
using KataBankOcr.Interfaces;
using NUnit.Framework;

namespace KataTest
{
    [TestFixture]
    public class LineSplitterTests
    {
        private ILineSplitter _target;

        [SetUp]
        public void SetUp()
        {
            _target = new LineSplitter();
        }

        [Test]
        public void Split_ValidListOfLine_ReturnsListOfEntry()
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
    }
}
