using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TriviaTest
{
    public partial class GameTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void wasCorrectlyAnswered_NewGame_ThrowException()
        {
            _target.wasCorrectlyAnswered();
        }

        #region 1PlayerCallMethodNTimesAssertReturnValue

        [TestMethod]
        public void wasCorrectlyAnswered_1Player_ReturnTrue()
        {
            AddHansWurstsWithNumber(1);

            var actual = WasCorrectlyAnsweredNTimes(1);

            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void wasCorrectlyAnswered_1PlayerCall5Times_ReturnTrue()
        {
            AddHansWurstsWithNumber(1);

            var actual = WasCorrectlyAnsweredNTimes(5);

            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void wasCorrectlyAnswered_1PlayerCall6Times_ReturnFalse()
        {
            AddHansWurstsWithNumber(1);

            var actual = WasCorrectlyAnsweredNTimes(6);

            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void wasCorrectlyAnswered_1PlayerCall7Times_ReturnTrue()
        {
            AddHansWurstsWithNumber(1);

            var actual = WasCorrectlyAnsweredNTimes(7);

            Assert.IsTrue(actual);
        }

        #endregion

        #region MultiplePlayerCallMethodNTimesAssertReturnValue

        [TestMethod]
        public void wasCorrectlyAnswered_2PlayerCall11Times_ReturnFalse()
        {
            AddHansWurstsWithNumber(2);
            
            var actual = WasCorrectlyAnsweredNTimes(11);

            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void wasCorrectlyAnswered_3PlayerCall17Times_ReturnFalse()
        {
            AddHansWurstsWithNumber(3);
            
            var actual = WasCorrectlyAnsweredNTimes(17);

            Assert.IsFalse(actual);
        }

        #endregion

        #region 1PlayerCallMethodNTimesAssertText

        [TestMethod]
        public void wasCorrectlyAnswered_1Player_ExpectedText()
        {
            AddHansWurstsWithNumber(1);
            _output.Clear();
            var expected = "Answer was corrent!!!!" + _newLine
                         + "Hans Wurst 1 now has 1 Gold Coins." + _newLine;

            _target.wasCorrectlyAnswered();

            Assert.AreEqual(expected, _output.ToString());
        }

        [TestMethod]
        public void wasCorrectlyAnswered_1PlayerCall2Times_ExpectedText()
        {
            AddHansWurstsWithNumber(1);
            WasCorrectlyAnsweredNTimes(1);
            _output.Clear();
            var expected = "Answer was corrent!!!!" + _newLine
                         + "Hans Wurst 1 now has 2 Gold Coins." + _newLine;

            _target.wasCorrectlyAnswered();

            Assert.AreEqual(expected, _output.ToString());
        }

        #endregion

        #region 2PlayerCallMethodNTimesAssertText

        [TestMethod]
        public void wasCorrectlyAnswered_2PlayerCall2Times_ExpectedText()
        {
            AddHansWurstsWithNumber(2);
            WasCorrectlyAnsweredNTimes(1);
            _output.Clear();
            var expected = "Answer was corrent!!!!" + _newLine
                         + "Hans Wurst 2 now has 1 Gold Coins." + _newLine;

            _target.wasCorrectlyAnswered();

            Assert.AreEqual(expected, _output.ToString());
        }

        [TestMethod]
        public void wasCorrectlyAnswered_2PlayerCall3Times_ExpectedText()
        {
            AddHansWurstsWithNumber(2);
            WasCorrectlyAnsweredNTimes(2);
            _output.Clear();
            var expected = "Answer was corrent!!!!" + _newLine
                         + "Hans Wurst 1 now has 2 Gold Coins." + _newLine;

            _target.wasCorrectlyAnswered();

            Assert.AreEqual(expected, _output.ToString());
        }

        [TestMethod]
        public void wasCorrectlyAnswered_2PlayerCall4Times_ExpectedText()
        {
            AddHansWurstsWithNumber(2);
            WasCorrectlyAnsweredNTimes(3);
            _output.Clear();
            var expected = "Answer was corrent!!!!" + _newLine
                         + "Hans Wurst 2 now has 2 Gold Coins." + _newLine;

            _target.wasCorrectlyAnswered();

            Assert.AreEqual(expected, _output.ToString());
        }

        [TestMethod]
        public void wasCorrectlyAnswered_2PlayerCall11Times_ExpectedText()
        {
            AddHansWurstsWithNumber(2);
            WasCorrectlyAnsweredNTimes(10);
            _output.Clear();
            var expected = "Answer was corrent!!!!" + _newLine
                         + "Hans Wurst 1 now has 6 Gold Coins." + _newLine;

            _target.wasCorrectlyAnswered();

            Assert.AreEqual(expected, _output.ToString());
        }

        #endregion

        [TestMethod]
        public void wasCorrectlyAnswered_3PlayerCall16Times_ExpectedText()
        {
            AddHansWurstsWithNumber(3);
            WasCorrectlyAnsweredNTimes(15);
            _output.Clear();
            var expected = "Answer was corrent!!!!" + _newLine
                         + "Hans Wurst 1 now has 6 Gold Coins." + _newLine;

            _target.wasCorrectlyAnswered();

            Assert.AreEqual(expected, _output.ToString());
        }

        #region 1PlayerFirstAnswerWasFalseAssertReturnValue

        [TestMethod]
        public void wasCorrectlyAnswered_1PlayerFirstAnswerWasFalse_ReturnTrue()
        {
            AddHansWurstsWithNumber(1);
            _target.wrongAnswer();
            _output.Clear();

            var actual = _target.wasCorrectlyAnswered();

            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void wasCorrectlyAnswered_1PlayerFirstAnswerWasFalseRoll1_ReturnTrue()
        {
            AddHansWurstsWithNumber(1);
            _target.wrongAnswer();
            _target.roll(1);
            _output.Clear();

            var actual = _target.wasCorrectlyAnswered();

            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void wasCorrectlyAnswered_1PlayerFirstAnswerWasFalseRoll2_ReturnTrue()
        {
            AddHansWurstsWithNumber(1);
            _target.wrongAnswer();
            _target.roll(2);
            _output.Clear();

            var actual = _target.wasCorrectlyAnswered();

            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void wasCorrectlyAnswered_1PlayerFirstAnswerWasFalseRoll3_ReturnTrue()
        {
            AddHansWurstsWithNumber(1);
            _target.wrongAnswer();
            _target.roll(3);
            _output.Clear();

            var actual = _target.wasCorrectlyAnswered();

            Assert.IsTrue(actual);
        }

        #endregion

        #region 1PlayerFirstAnswerWasFalseReturnExpectedText 

        [TestMethod]
        public void wasCorrectlyAnswered_1PlayerFirstAnswerWasFalseRoll1_ReturnExpectedText()
        {
            AddHansWurstsWithNumber(1);
            _target.wrongAnswer();
            _target.roll(1);
            _output.Clear();
            var expected = "Answer was correct!!!!" + _newLine
                         + "Hans Wurst 1 now has 1 Gold Coins." + _newLine;

            _target.wasCorrectlyAnswered();

            Assert.AreEqual(expected, _output.ToString());
        }

        [TestMethod]
        public void wasCorrectlyAnswered_1PlayerFirstAnswerWasFalseRoll2_NothingObviouslyHappend()
        {
            AddHansWurstsWithNumber(1);
            _target.wrongAnswer();
            _target.roll(2);
            _output.Clear();
            var expected = string.Empty;

            _target.wasCorrectlyAnswered();

            Assert.AreEqual(expected, _output.ToString());
        }

        [TestMethod]
        public void wasCorrectlyAnswered_1PlayerFirstAnswerWasFalseRoll3_ExpectedTextIsEmpty()
        {
            AddHansWurstsWithNumber(1);
            _target.wrongAnswer();
            _target.roll(3);
            _output.Clear();
            var expected = "Answer was correct!!!!" + _newLine
                         + "Hans Wurst 1 now has 1 Gold Coins." + _newLine;

            _target.wasCorrectlyAnswered();

            Assert.AreEqual(expected, _output.ToString());
        }

        [TestMethod]
        public void wasCorrectlyAnswered_1PlayerFirstAnswerWasFalseRoll4_NothingObviouslyHappend()
        {
            AddHansWurstsWithNumber(1);
            _target.wrongAnswer();
            _target.roll(4);
            _output.Clear();
            var expected = string.Empty;

            _target.wasCorrectlyAnswered();

            Assert.AreEqual(expected, _output.ToString());
        }

        [TestMethod]
        public void wasCorrectlyAnswered_1PlayerFirstAnswerWasFalseRoll5_ExpectedTextIsEmpty()
        {
            AddHansWurstsWithNumber(1);
            _target.wrongAnswer();
            _target.roll(5);
            _output.Clear();
            var expected = "Answer was correct!!!!" + _newLine
                         + "Hans Wurst 1 now has 1 Gold Coins." + _newLine;

            _target.wasCorrectlyAnswered();

            Assert.AreEqual(expected, _output.ToString());
        }

        [TestMethod]
        public void wasCorrectlyAnswered_1PlayerFirstAnswerWasFalseRoll6_NothingObviouslyHappend()
        {
            AddHansWurstsWithNumber(1);
            _target.wrongAnswer();
            _target.roll(6);
            _output.Clear();
            var expected = string.Empty;

            _target.wasCorrectlyAnswered();

            Assert.AreEqual(expected, _output.ToString());
        }

        #endregion


        #region New Tests

        [TestMethod]
        public void wasCorrectlyAnswered_Player1WrongAnswerPlayer2CorrectAnswer_ReturnAddCoinPlayer2()
        {
            AddHansWurstsWithNumber(2);
            _target.roll(3);
            _target.wrongAnswer();
            _target.roll(4);
            _output.Clear();
            var expected = "Answer was corrent!!!!" + _newLine
                        + "Hans Wurst 2 now has 1 Gold Coins." + _newLine;

            _target.wasCorrectlyAnswered();

            Assert.AreEqual(expected, _output.ToString());
        }

        [TestMethod]
        public void wasCorrectlyAnswered_TwoPlayerBothinPenaltyBoxFirstOutSecondNot_OutputIsNothing()
        {
            AddHansWurstsWithNumber(2);
            _target.roll(3);
            _target.wrongAnswer();
            _target.roll(4);
            _target.wrongAnswer();
            _target.roll(2);
            _target.wasCorrectlyAnswered();
            _target.roll(1);
            _output.Clear();
            var expected = "Question was incorrectly answered" + _newLine
                + "Hans Wurst 2 was sent to the penalty box" + _newLine;

            // IS Wrong answer possible when player is in Penalty Box?
            _target.wrongAnswer();

            Assert.AreEqual(expected, _output.ToString());
        }

        [TestMethod]
        public void wasCorrectlyAnswered_TwoPlayerDifferentRolls_CorrectAddedCorrectForEachPlayer()
        {
            AddHansWurstsWithNumber(2);
            _output.Clear();
            var expected = RollAndCorrectAnswer(1, 1, 1, "Science", 0, 1)
               + RollAndCorrectAnswer(2, 2, 2, "Sports", 0, 1)
               + RollAndCorrectAnswer(1, 3, 4, "Pop", 0, 2)
               + RollAndCorrectAnswer(2, 4, 6, "Sports", 1, 2);

            _target.roll(1);
            _target.wasCorrectlyAnswered();
            _target.roll(2);
            _target.wasCorrectlyAnswered();
            _target.roll(3);
            _target.wasCorrectlyAnswered();
            _target.roll(4);
            _target.wasCorrectlyAnswered();

            Assert.AreEqual(expected, _output.ToString());
        }

        private string RollAndCorrectAnswer(int player, int roll, int location, string category, int number, object coin)
        {
            return string.Format("Hans Wurst {0} is the current player", player) + _newLine 
                    + string.Format("They have rolled a {0}", roll) + _newLine
                    + string.Format("Hans Wurst {0}'s new location is {1}", player, location) + _newLine
                    + string.Format("The category is {0}", category) + _newLine
                    + string.Format("{0} Question {1}", category, number) + _newLine
                    + string.Format("Answer was corrent!!!!") + _newLine
                    + string.Format("Hans Wurst {0} now has {1} Gold Coins.", player, coin) + _newLine
                    ;
        }
        
        #endregion
        
        #region Test Helper

        private bool WasCorrectlyAnsweredNTimes(int times)
        {
            var actual = false;
            for (int i = 0; i < times; i++)
            {
                actual = _target.wasCorrectlyAnswered();
            }
            return actual;
        }
        
        #endregion
    }
}
