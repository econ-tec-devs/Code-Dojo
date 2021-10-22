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
            var target = new KataTicTacToe_20211021.TicTacToe();
            string expected = "         ";

            string actual = target.Initialize();
            
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Move_FirstMoveInputValidCoordinate_ReturnBoardWithOneX()
        {
            var target = new KataTicTacToe_20211021.TicTacToe();
            var inputValidCoordinate = "A0";
            string expected = "X        ";

            string actual = target.Move(inputValidCoordinate);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}