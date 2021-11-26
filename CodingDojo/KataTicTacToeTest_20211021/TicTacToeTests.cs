using NUnit.Framework;
using KataTicTacToe_20211021;

namespace KataTicTacToeTest_20211021
{
    public class TicTacToeTests
    {
        private TicTacToe _target;

        [SetUp]
        public void Setup()
        {
            _target = new TicTacToe();
        }

        [Test]
        public void Initialize_CreateNewBoard_ReturnEmptyBoard()
        {
            string expected = "         ";
            
            Assert.That(_target.Board, Is.EqualTo(expected));
        }

        [TestCase("A0", "X        ")]
        [TestCase("B0", " X       ")]
        [TestCase("C0", "  X      ")] 
        [TestCase("A1", "   X     ")]
        [TestCase("B1", "    X    ")]
        [TestCase("C1", "     X   ")]
        [TestCase("A2", "      X  ")]
        [TestCase("B2", "       X ")]
        [TestCase("C2", "        X")]
        public void Move_FirstMoveInputValidCoordinate_ReturnBoardWithOneX(string coordinate, string expectedBoard)
        {
            string actual = _target.Move(coordinate);

            Assert.That(actual, Is.EqualTo(expectedBoard));
        }
        
        [TestCase("C0", "X O      ")]
        [TestCase("C1", "X    O   ")]
        public void Move_SecondMoveInputValidCoordinate_ReturnBoardWithOneXAndOneO(string coordinate, string expectedBoard)
        {
            _target.Move("A0");
            
            string actual = _target.Move(coordinate);

            Assert.That(actual, Is.EqualTo(expectedBoard));
        }

        [TestCase("A0", "X        ")]
        public void Move_InputInvalidCoordinate_ReturnOriginalBoard(string coordinate, string expectedBoard)
        {
            _target.Move("A0");

            string actual = _target.Move(coordinate);

            Assert.That(actual, Is.EqualTo(expectedBoard));
        }
    }
}