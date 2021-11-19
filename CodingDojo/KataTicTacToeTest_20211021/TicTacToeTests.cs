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
        [TestCase("C0", "  X      ")] 
        [TestCase("A1", "   X     ")]
        [TestCase("B1", "    X    ")]
        [TestCase("C1", "     X   ")]
        [TestCase("A2", "      X  ")]
        [TestCase("B2", "       X ")]
        [TestCase("C2", "        X")]
        public void Move_FirstMoveInputValidCoordinate_ReturnBoardWithOneX(string coordinate, string expectedBoard)
        {
            var target = new TicTacToe();
            
            string actual = target.Move(coordinate);

            Assert.That(actual, Is.EqualTo(expectedBoard));
        }
        
        [TestCase("C0", "X O      ")]
        public void Move_SecondMoveInputValidCoordinate_ReturnBoardWithOneXAndOneO(string coordinate, string expectedBoard)
        {
            var target = new TicTacToe();
            target.Initialize();
            target.Move("A0");
            
            string actual = target.Move(coordinate);

            Assert.That(actual, Is.EqualTo(expectedBoard));
        }
    }
}