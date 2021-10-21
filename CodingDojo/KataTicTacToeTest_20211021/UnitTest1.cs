using NUnit.Framework;

namespace KataTicTacToeTest_20211021
{
    public class Tests
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
    }
}