// -----------------------------------------------------------------------
// <copyright file="Game.cs" company="econ-tec GmbH">
//     Copyright (c) econ-tec GmbH. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------
namespace Trivia
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Game
    {
        private static readonly int MaxPlayer = 6;
        private readonly LinkedList<Player> _players = new LinkedList<Player>();
        private readonly LinkedList<string> _popQuestions = new LinkedList<string>();
        private readonly LinkedList<string> _rockQuestions = new LinkedList<string>();
        private readonly LinkedList<string> _scienceQuestions = new LinkedList<string>();
        private readonly LinkedList<string> _sportsQuestions = new LinkedList<string>();
        private readonly int maxQuestionsPerCategory = 50;
        private readonly int minPlayer = 2;
        private Player _currentPlayer;
        private bool _isGettingOutOfPenaltyBox;

        public Game()
        {
            this.InitializeGame();
        }

        public bool IsPlayable()
        {
            return (this.HowManyPlayers() >= this.minPlayer);
        }

        public bool Add(string playerName)
        {
            this._players.AddLast(new Player { Name = playerName });
            this._currentPlayer = this._players.First();
            Console.WriteLine($"{playerName} was added");
            Console.WriteLine($"They are player number {this._players.Count}");
            return true;
        }

        public int HowManyPlayers()
        {
            return this._players.Count;
        }

        public void Roll(int roll)
        {
            Console.WriteLine($"{this._currentPlayer.Name} is the current player");
            Console.WriteLine($"They have rolled a {roll}");

            if (this._currentPlayer.IsInPenaltyBox)
            {
                if (IsEven(roll))
                {
                    this._isGettingOutOfPenaltyBox = true;

                    Console.WriteLine($"{this._currentPlayer.Name} is getting out of the penalty box");
                    this.MoveCurrentPlayer(roll);
                    this.AskQuestion();
                }
                else
                {
                    Console.WriteLine($"{this._currentPlayer.Name} is not getting out of the penalty box");
                    this._isGettingOutOfPenaltyBox = false;
                }
            }
            else
            {
                this.MoveCurrentPlayer(roll);
                this.AskQuestion();
            }
        }

        public bool WasCorrectlyAnswered()
        {
            if (this._currentPlayer.IsInPenaltyBox)
            {
                if (this._isGettingOutOfPenaltyBox)
                {
                    this.CorrectAnswer("correct");
                    var winner = this.DidPlayerWin();
                    this.NextPlayer();
                    return winner;
                }
                else
                {
                    this.NextPlayer();
                    return true;
                }
            }
            else
            {
                this.CorrectAnswer("corrent");
                var winner = this.DidPlayerWin();
                this.NextPlayer();
                return winner;
            }
        }

        public bool WrongAnswer()
        {
            Console.WriteLine("Question was incorrectly answered");
            Console.WriteLine($"{this._currentPlayer.Name} was sent to the penalty box");
            this._currentPlayer.IsInPenaltyBox = true;
            this.NextPlayer();
            return true;
        }

        private bool IsEven(int roll)
        {
            return roll % 2 != 0;
        }

        private void CorrectAnswer(string correct)
        {
            Console.WriteLine($"Answer was {correct}!!!!");
            this._currentPlayer.Purse++;
            Console.WriteLine($"{this._currentPlayer.Name} now has {this._currentPlayer.Purse} Gold Coins.");
        }

        private void MoveCurrentPlayer(int roll)
        {
            this._currentPlayer.Place += roll;
            if (this._currentPlayer.Place > 11)
            {
                this._currentPlayer.Place -= 12;
            }

            Console.WriteLine($"{this._currentPlayer.Name}'s new location is {this._currentPlayer.Place}");
            Console.WriteLine($"The category is {this.CurrentCategory()}");
        }

        private void NextPlayer()
        {
            var currentPlayer = this._players.First();
            this._players.RemoveFirst();
            this._players.AddLast(currentPlayer);
            this._currentPlayer = this._players.First();
        }

        private void InitializeGame()
        {
            for (var index = 0; index < this.maxQuestionsPerCategory; index++)
            {
                this._popQuestions.AddLast(this.CreateQuestion(Category.Pop, index));
                this._scienceQuestions.AddLast(this.CreateQuestion(Category.Science, index));
                this._sportsQuestions.AddLast(this.CreateQuestion(Category.Sports, index));
                this._rockQuestions.AddLast(this.CreateQuestion(Category.Rock, index));
            }
        }

        private string CreateQuestion(Category category, int index)
        {
            return $"{category} Question {index}";
        }

        private void AskQuestion()
        {
            switch (this.CurrentCategory())
            {
                case Category.Pop:
                    this.DrawFirstQuestion(this._popQuestions);
                    break;
                case Category.Science:
                    this.DrawFirstQuestion(this._scienceQuestions);
                    break;
                case Category.Sports:
                    this.DrawFirstQuestion(this._sportsQuestions);
                    break;
                case Category.Rock:
                    this.DrawFirstQuestion(this._rockQuestions);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private void DrawFirstQuestion(LinkedList<string> questions)
        {
            Console.WriteLine(questions.First());
            questions.RemoveFirst();
        }

        private Category CurrentCategory()
        {
            switch (this._currentPlayer.Place)
            {
                case 0:
                case 4:
                case 8:
                    return Category.Pop;
                case 1:
                case 5:
                case 9:
                    return Category.Science;
                case 2:
                case 6:
                case 10:
                    return Category.Sports;
                default:
                    return Category.Rock;
            }
        }

        private bool DidPlayerWin()
        {
            return this._currentPlayer.Purse != 6;
        }
    }

    internal class Player
    {
        public string Name { get; set; }

        public int Place { get; set; }

        public int Purse { get; set; }

        public bool IsInPenaltyBox { get; set; }
    }

    internal enum Category
    {
        Pop,
        Science,
        Sports,
        Rock
    }
}
