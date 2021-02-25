using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TriviaTest
{
    public partial class GameTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void wrongAnswer_NewGame_ThrowException()
        {
            _target.wrongAnswer();
        }

        [TestMethod]
        public void wrongAnswer_GameWithOnePlayer_AnswerIsTrue()
        {
            _target.add("Hans Wurst 1");

            var actual = _target.wrongAnswer();

            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void wrongAnswer_GameWithOnePlayer_ReturnsExpectedText()
        {
            _target.add("Hans Wurst 1");
            _output.Clear();
            var expected = "Question was incorrectly answered" + _newLine 
                         + "Hans Wurst 1 was sent to the penalty box" + _newLine;

            _target.wrongAnswer();

            Assert.AreEqual(expected, _output.ToString());
        }

        [TestMethod]
        public void wrongAnswer_GameWithOnePlayerCall2Times_AnswerisTrue()
        {
            _target.add("Hans Wurst 1");

            var actual = _target.wrongAnswer();

            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void wrongAnswer_GameWithOnePlayerCall2Times_ReturnsExpectedText()
        {
            _target.add("Hans Wurst 1");
            _target.wrongAnswer();
            _output.Clear();
            var expected = "Question was incorrectly answered" + _newLine
                         + "Hans Wurst 1 was sent to the penalty box" + _newLine;

            _target.wrongAnswer();

            Assert.AreEqual(expected, _output.ToString());
        }

        [TestMethod]
        public void wrongAnswer_GameWithTwoPlayer_ReturnsExpectedText()
        {
            _target.add("Hans Wurst 1");
            _target.add("Hans Wurst 2");
            _output.Clear();
            var expected = "Question was incorrectly answered" + _newLine
                         + "Hans Wurst 1 was sent to the penalty box" + _newLine;

            _target.wrongAnswer();

            Assert.AreEqual(expected, _output.ToString());
        }

        [TestMethod]
        public void wrongAnswer_GameWithTwoPlayerCall2Times_ReturnsExpectedTextWithPlayer2()
        {
            _target.add("Hans Wurst 1");
            _target.add("Hans Wurst 2");
            _target.wrongAnswer();
            _output.Clear();
            var expected = "Question was incorrectly answered" + _newLine
                         + "Hans Wurst 2 was sent to the penalty box" + _newLine;

            _target.wrongAnswer();

            Assert.AreEqual(expected, _output.ToString());
        }
    
        [TestMethod]
        public void wrongAnswer_GameWithTwoPlayerCall3Times_ReturnsExpectedTextWithPlayer1()
        {
            _target.add("Hans Wurst 1");
            _target.add("Hans Wurst 2");
            _target.wrongAnswer();
            _target.wrongAnswer();
            _output.Clear();
            var expected = "Question was incorrectly answered" + _newLine
                         + "Hans Wurst 1 was sent to the penalty box" + _newLine;

            _target.wrongAnswer();

            Assert.AreEqual(expected, _output.ToString());
        }
    
        [TestMethod]
        public void wrongAnswer_GameWithTwoPlayerCall3Times_ReturnsExpectedTextWithPlayer3()
        {
            _target.add("Hans Wurst 1");
            _target.add("Hans Wurst 2");
            _target.add("Hans Wurst 3");
            _target.wrongAnswer();
            _target.wrongAnswer();
            _output.Clear();
            var expected = "Question was incorrectly answered" + _newLine
                         + "Hans Wurst 3 was sent to the penalty box" + _newLine;

            _target.wrongAnswer();

            Assert.AreEqual(expected, _output.ToString());
        }
    
    }
}
