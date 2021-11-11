using NUnit.Framework;
using KataTicTacToe_20211021;

namespace KataTicTacToeTest_20211021
{
    public class TicTacToeTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Initialize_CreateNewBoard_ReturnEmptyBoard()
        {
            var target = new TicTacToe();
            string expected = "         ";

            string actual = target.Initialize();
            
            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCase("A0", "X        ")]
        [TestCase("B0", " X       ")]
        public void Move_FirstMoveInputValidCoordinate_ReturnBoardWithOneX(string coordinate, string expectedBoard)
        {
            var target = new TicTacToe();
            
            string actual = target.Move(coordinate);

            Assert.That(actual, Is.EqualTo(expectedBoard));
        }
    }
}