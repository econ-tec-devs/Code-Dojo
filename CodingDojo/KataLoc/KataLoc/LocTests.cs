using NUnit.Framework;

namespace KataLOC
{
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

            var expected = new LinesCount() { CommentsWhitespaceLineCount = 0, LineOfCodeCount = 0 };

            LinesCount actual = Loc.LineOfCode(string.Empty);

            Assert.That(actual.CommentsWhitespaceLineCount, Is.EqualTo(expected.CommentsWhitespaceLineCount));
            Assert.That(actual.LineOfCodeCount, Is.EqualTo(expected.LineOfCodeCount));
        }
    }
}