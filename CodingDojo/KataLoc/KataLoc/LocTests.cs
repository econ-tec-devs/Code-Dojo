using KataLOC;
using NUnit.Framework;

namespace KataLocTest
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
        
        [Test]
        public void LineOfCode_OneLineOfCode_ReturnOneLineCount()
        {
            var text = $"Console.WriteLine()";
            var expected = new LinesCount() { CommentsWhitespaceLineCount = 0, LineOfCodeCount = 1 };

            LinesCount actual = Loc.LineOfCode(text);

            Assert.That(actual.CommentsWhitespaceLineCount, Is.EqualTo(expected.CommentsWhitespaceLineCount));
            Assert.That(actual.LineOfCodeCount, Is.EqualTo(expected.LineOfCodeCount));
        }
    }

   
}