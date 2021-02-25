using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TriviaTest
{
    public partial class GameTests
    {
        private const string _questionPop       = "Pop";
        private const string _questionScience   = "Science";
        private const string _questionSports    = "Sports";
        private const string _questionRock      = "Rock";

        readonly Dictionary<int, string> dictPosQuestion =  
            new Dictionary<int, string>()
            {
                {0, _questionPop},      {1, _questionScience},  {2, _questionSports},
                {3, _questionRock},     {4, _questionPop},      {5, _questionScience}, 
                {6, _questionSports},   {7, _questionRock},     {8, _questionPop}, 
                {9, _questionScience},  {10, _questionSports},  {11, _questionRock},
            };

        #region Roll_NewGamePlayer1Location0DiceXAndAssertQuestionCategory

        [TestMethod]
        public void roll_NewGamePlayer1Location0Dice0_ReturnPop()
        {
            NewGame1PlayerInputDiceAndAssertQuestion(0, _questionPop);
        }

        [TestMethod]
        public void roll_NewGamePlayer1Location0Dice1_ReturnScience()
        {
            NewGame1PlayerInputDiceAndAssertQuestion(1, _questionScience);
        }

        [TestMethod]
        public void roll_NewGamePlayer1Location0Dice2_ReturnSports()
        {
            NewGame1PlayerInputDiceAndAssertQuestion(2, _questionSports);
        }

        [TestMethod]
        public void roll_NewGamePlayer1Location0Dice3_ReturnRock()
        {
            NewGame1PlayerInputDiceAndAssertQuestion(3, _questionRock);
        }

        [TestMethod]
        public void roll_NewGamePlayer1Location0Dice4_ReturnPop()
        {
            NewGame1PlayerInputDiceAndAssertQuestion(4, _questionPop);
        }

        [TestMethod]
        public void roll_NewGamePlayer1Location0Dice5_ReturnScience()
        {
            NewGame1PlayerInputDiceAndAssertQuestion(5, _questionScience);
        }

        [TestMethod]
        public void roll_NewGamePlayer1Location0Dice6_ReturnSports()
        {
            NewGame1PlayerInputDiceAndAssertQuestion(6, _questionSports);
        }

        [TestMethod]
        public void roll_NewGamePlayer1Location0Dice7_ReturnRock()
        {
            NewGame1PlayerInputDiceAndAssertQuestion(7, _questionRock);
        }

        [TestMethod]
        public void roll_NewGamePlayer1Location0Dice8_ReturnPop()
        {
            NewGame1PlayerInputDiceAndAssertQuestion(8, _questionPop);
        }

        [TestMethod]
        public void roll_NewGamePlayer1Location0Dice9_ReturnScience()
        {
            NewGame1PlayerInputDiceAndAssertQuestion(9, _questionScience);
        }

        [TestMethod]
        public void roll_NewGamePlayer1Location0Dice10_ReturnSports()
        {
            NewGame1PlayerInputDiceAndAssertQuestion(10, _questionSports);
        }

        [TestMethod]
        public void roll_NewGamePlayer1Location0Dice11_ReturnRock()
        {
            NewGame1PlayerInputDiceAndAssertQuestion(11, _questionRock);
        }

        [TestMethod]
        public void roll_NewGamePlayer1Location0Dice12_ReturnPop()
        {
            NewGame1PlayerInputDiceAndAssertQuestion(12, _questionPop);
        }

        #endregion

        #region Roll_NewGamePlayer1Location0DiceXAndAssertNewPosition

        [TestMethod]
        public void roll_NewGamePlayer1Location0Dice0_NewPositionIs0()
        {
            NewGamePlayer1Location0InputDiceAssertNewPosition(0, 0);
        }

        [TestMethod]
        public void roll_NewGamePlayer1Location0Dice1_NewPositionIs1()
        {
            NewGamePlayer1Location0InputDiceAssertNewPosition(1, 1);
        }

        [TestMethod]
        public void roll_NewGamePlayer1Location0Dice2_NewPositionIs2()
        {
            NewGamePlayer1Location0InputDiceAssertNewPosition(2, 2);
        }

        [TestMethod]
        public void roll_NewGamePlayer1Location0Dice3_NewPositionIs3()
        {
            NewGamePlayer1Location0InputDiceAssertNewPosition(3, 3);
        }

        [TestMethod]
        public void roll_NewGamePlayer1Location0Dice4_NewPositionIs4()
        {
            NewGamePlayer1Location0InputDiceAssertNewPosition(4, 4);
        }

        [TestMethod]
        public void roll_NewGamePlayer1Location0Dice5_NewPositionIs5()
        {
            NewGamePlayer1Location0InputDiceAssertNewPosition(5, 5);
        }

        [TestMethod]
        public void roll_NewGamePlayer1Location0Dice6_NewPositionIs6()
        {
            NewGamePlayer1Location0InputDiceAssertNewPosition(6, 6);
        }

        [TestMethod]
        public void roll_NewGamePlayer1Location0Dice7_NewPositionIs7()
        {
            NewGamePlayer1Location0InputDiceAssertNewPosition(7, 7);
        }

        [TestMethod]
        public void roll_NewGamePlayer1Location0Dice8_NewPositionIs8()
        {
            NewGamePlayer1Location0InputDiceAssertNewPosition(8, 8);
        }

        [TestMethod]
        public void roll_NewGamePlayer1Location0Dice9_NewPositionIs9()
        {
            NewGamePlayer1Location0InputDiceAssertNewPosition(9, 9);
        }

        [TestMethod]
        public void roll_NewGamePlayer1Location0Dice10_NewPositionIs10()
        {
            NewGamePlayer1Location0InputDiceAssertNewPosition(10, 10);
        }

        [TestMethod]
        public void roll_NewGamePlayer1Location0Dice11_NewPositionIs11()
        {
            NewGamePlayer1Location0InputDiceAssertNewPosition(11, 11);
        }

        [TestMethod]
        public void roll_NewGamePlayer1Location0Dice2x6_PositionIsResetTo0()
        {
            AddHansWurstsWithNumber(1);
            var dice = 6;
            _target.roll(dice);
            _output.Clear();
            _target.roll(dice);
                
            var expected = ExpectedText("Hans Wurst 1", dice, 0);

            Assert.AreEqual(expected, _output.ToString());
        }

        [TestMethod]
        public void roll_NewGamePlayer1Location0Dice12_PositionIsResetTo0()
        {
            AddHansWurstsWithNumber(1);
            var dice = 12;
            _output.Clear();
            _target.roll(dice);

            var expected = ExpectedText("Hans Wurst 1", dice, 0);

            Assert.AreEqual(expected, _output.ToString());
        }

        #endregion

        [TestMethod]
        public void roll_NewGamePlayer1Location8Dice6_PositionIsResetTo2()
        {
            AddHansWurstsWithNumber(1);
            _target.roll(4);
            _target.roll(4);
            var dice = 6;
            _output.Clear();
            _target.roll(dice);

            var expected = ExpectedText("Hans Wurst 1", dice, 2);

            Assert.AreEqual(expected, _output.ToString());
        }

        [TestMethod]
        public void roll_NewGamePlayer1Location8InPenalityBoxDice5_LeavesPenalityBoxAndPositionIsResetTo1()
        {
            AddHansWurstsWithNumber(1);
            _target.roll(4);
            _target.roll(4);
            _target.wrongAnswer();
            var dice = 5;
            _output.Clear();
            _target.roll(dice);

            var expected = ExpectedTextOutOfPenality("Hans Wurst 1", dice, 1);

            Assert.AreEqual(expected, _output.ToString());
        }

        [TestMethod]
        public void roll_NewGamePlayer1Location8InPenalityBoxDice6_DoesNotLeavesPenalityBoxAndPositionIs0()
        {
            AddHansWurstsWithNumber(1);
            _target.roll(4);
            _target.roll(4);
            _target.wrongAnswer();
            var dice = 6;
            _output.Clear();
            _target.roll(dice);

            var expected = ExpectedTextNotOutOfPenality("Hans Wurst 1", dice);

            Assert.AreEqual(expected, _output.ToString());
        }


        [TestMethod]
        public void roll_OnePlayerDiceNegative1_CategoryIsRock()
        {
            int dice = -1;
            string expected = "The category is Rock";
            _target.add("Hans Wurst");
            _target.roll(dice);

            Assert.IsTrue(_output.ToString().Contains(expected));
        }

        [TestMethod]
        public void roll_OnePlayerDiceNegative2_CategoryIsRock()
        {
            int dice = -2;
            string expected = "The category is Rock";
            _target.add("Hans Wurst");
            _target.roll(dice);

            Assert.IsTrue(_output.ToString().Contains(expected));
        }

        [TestMethod]
        public void roll_OnePlayerDiceNegative4711_CategoryIsRock()
        {
            int dice = -4711;
            string expected = "The category is Rock";
            _target.add("Hans Wurst");
            _target.roll(dice);

            Assert.IsTrue(_output.ToString().Contains(expected));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void roll_NoPlayerDice1_ThrowException()
        {
            int dice = 1;
            _target.roll(dice);
        }

        [TestMethod]
        public void roll_OnePlayerLocation0Dice11_LocationIs11()
        {
            var dice = 11;
            var expected = "Hans Wurst's new location is 11";
            _target.add("Hans Wurst");

            _target.roll(dice);

            Assert.IsTrue(_output.ToString().Contains(expected));
        }

        [TestMethod]
        public void roll_OnePlayerLocation0Dice11_LocationIs0()
        {
            var dice = 12;
            var expected = "Hans Wurst's new location is 0";
            _target.add("Hans Wurst");

            _target.roll(dice);

            Assert.IsTrue(_output.ToString().Contains(expected));
        }

        #region Test Helper

        private void NewGamePlayer1Location0InputDiceAssertNewPosition(int dice, int newPosition)
        {
            AddHansWurstsWithNumber(1);
            _output.Clear();
            _target.roll(dice);

            var expected = ExpectedText("Hans Wurst 1", dice, newPosition);

            Assert.AreEqual(expected, _output.ToString());
        }

        private void NewGame1PlayerInputDiceAndAssertQuestion(int dice, string question)
        {
            AddHansWurstsWithNumber(1);
            _output.Clear();

            _target.roll(dice);

            Assert.IsTrue(_output.ToString().Contains(question));
        }

        private string ExpectedText(string playerName, int dice, int newLocation)
        {
            var question = dictPosQuestion[newLocation];
            return String.Format(
                "{0} is the current player{1}" +
                "They have rolled a {2}{1}" +
                "{0}'s new location is {4}{1}" +
                "The category is {3}{1}" +
                "{3} Question 0{1}",
                playerName, _newLine, dice, question, newLocation );
        }

        private string ExpectedTextOutOfPenality(string playerName, int dice, int newLocation)
        {
            var question = dictPosQuestion[newLocation];
            return String.Format(
                "{0} is the current player{1}" +
                "They have rolled a {2}{1}" +
                "{0} is getting out of the penalty box{1}"+
                "{0}'s new location is {4}{1}" +
                "The category is {3}{1}" +
                "{3} Question 0{1}",
                playerName, _newLine, dice, question, newLocation );
        }        
        
        private string ExpectedTextNotOutOfPenality(string playerName, int dice )
        {
            return String.Format(
                "{0} is the current player{1}" +
                "They have rolled a {2}{1}" +
                "{0} is not getting out of the penalty box{1}",
                playerName, _newLine, dice );
        }

        #endregion

    }
}
