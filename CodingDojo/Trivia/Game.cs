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
        private static readonly int maxPlayer = 6;
        private readonly bool[] _inPenaltyBox = new bool[maxPlayer];

        private readonly int[] _places = new int[maxPlayer];
        private readonly List<string> _players = new List<string>();

        private readonly LinkedList<string> _popQuestions = new LinkedList<string>();
        private readonly int[] _purses = new int[maxPlayer];
        private readonly LinkedList<string> _rockQuestions = new LinkedList<string>();
        private readonly LinkedList<string> _scienceQuestions = new LinkedList<string>();
        private readonly LinkedList<string> _sportsQuestions = new LinkedList<string>();
        private readonly int maxQuestionsPerCategory = 50;
        private readonly int minPlayer = 2;

        private int _currentPlayer;
        private bool _isGettingOutOfPenaltyBox;

        public Game()
        {
            for (var i = 0; i < this.maxQuestionsPerCategory; i++)
            {
                this._popQuestions.AddLast("Pop Question " + i);
                this._scienceQuestions.AddLast(("Science Question " + i));
                this._sportsQuestions.AddLast(("Sports Question " + i));
                this._rockQuestions.AddLast(this.CreateRockQuestion(i));
            }
        }

        public string CreateRockQuestion(int index)
        {
            return "Rock Question " + index;
        }

        public bool IsPlayable()
        {
            return (this.HowManyPlayers() >= this.minPlayer);
        }

        public bool Add(string playerName)
        {
            this._players.Add(playerName);
            this._places[this.HowManyPlayers()] = 0;
            this._purses[this.HowManyPlayers()] = 0;
            this._inPenaltyBox[this.HowManyPlayers()] = false;

            Console.WriteLine(playerName + " was added");
            Console.WriteLine("They are player number " + this._players.Count);
            return true;
        }

        public int HowManyPlayers()
        {
            return this._players.Count;
        }

        public void Roll(int roll)
        {
            Console.WriteLine(this._players[this._currentPlayer] + " is the current player");
            Console.WriteLine("They have rolled a " + roll);

            if (this._inPenaltyBox[this._currentPlayer])
            {
                if (roll % 2 != 0)
                {
                    this._isGettingOutOfPenaltyBox = true;

                    Console.WriteLine(this._players[this._currentPlayer] + " is getting out of the penalty box");
                    this._places[this._currentPlayer] = this._places[this._currentPlayer] + roll;
                    if (this._places[this._currentPlayer] > 11)
                    {
                        this._places[this._currentPlayer] = this._places[this._currentPlayer] - 12;
                    }

                    Console.WriteLine(this._players[this._currentPlayer]
                                      + "'s new location is "
                                      + this._places[this._currentPlayer]);
                    Console.WriteLine("The category is " + this.CurrentCategory());
                    this.AskQuestion();
                }
                else
                {
                    Console.WriteLine(this._players[this._currentPlayer] + " is not getting out of the penalty box");
                    this._isGettingOutOfPenaltyBox = false;
                }
            }
            else
            {
                this._places[this._currentPlayer] = this._places[this._currentPlayer] + roll;
                if (this._places[this._currentPlayer] > 11)
                {
                    this._places[this._currentPlayer] = this._places[this._currentPlayer] - 12;
                }

                Console.WriteLine(this._players[this._currentPlayer]
                                  + "'s new location is "
                                  + this._places[this._currentPlayer]);
                Console.WriteLine("The category is " + this.CurrentCategory());
                this.AskQuestion();
            }
        }

        public bool WasCorrectlyAnswered()
        {
            if (this._inPenaltyBox[this._currentPlayer])
            {
                if (this._isGettingOutOfPenaltyBox)
                {
                    Console.WriteLine("Answer was correct!!!!");
                    this._purses[this._currentPlayer]++;
                    Console.WriteLine(this._players[this._currentPlayer]
                                      + " now has "
                                      + this._purses[this._currentPlayer]
                                      + " Gold Coins.");

                    var winner = this.DidPlayerWin();
                    this._currentPlayer++;
                    if (this._currentPlayer == this._players.Count)
                    {
                        this._currentPlayer = 0;
                    }

                    return winner;
                }
                else
                {
                    this._currentPlayer++;
                    if (this._currentPlayer == this._players.Count)
                    {
                        this._currentPlayer = 0;
                    }

                    return true;
                }
            }
            else
            {
                Console.WriteLine("Answer was corrent!!!!");
                this._purses[this._currentPlayer]++;
                Console.WriteLine(this._players[this._currentPlayer]
                                  + " now has "
                                  + this._purses[this._currentPlayer]
                                  + " Gold Coins.");

                var winner = this.DidPlayerWin();
                this._currentPlayer++;
                if (this._currentPlayer == this._players.Count)
                {
                    this._currentPlayer = 0;
                }

                return winner;
            }
        }

        public bool WrongAnswer()
        {
            Console.WriteLine("Question was incorrectly answered");
            Console.WriteLine(this._players[this._currentPlayer] + " was sent to the penalty box");
            this._inPenaltyBox[this._currentPlayer] = true;

            this._currentPlayer++;
            if (this._currentPlayer == this._players.Count)
            {
                this._currentPlayer = 0;
            }

            return true;
        }

        private void AskQuestion()
        {
            if (this.CurrentCategory() == Category.Pop)
            {
                Console.WriteLine(this._popQuestions.First());
                this._popQuestions.RemoveFirst();
            }

            if (this.CurrentCategory() == Category.Science)
            {
                Console.WriteLine(this._scienceQuestions.First());
                this._scienceQuestions.RemoveFirst();
            }

            if (this.CurrentCategory() == Category.Sports)
            {
                Console.WriteLine(this._sportsQuestions.First());
                this._sportsQuestions.RemoveFirst();
            }

            if (this.CurrentCategory() == Category.Rock)
            {
                Console.WriteLine(this._rockQuestions.First());
                this._rockQuestions.RemoveFirst();
            }
        }

        private Category CurrentCategory()
        {
            switch (this._places[this._currentPlayer])
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
            return !(this._purses[this._currentPlayer] == 6);
        }
    }

    internal enum Category
    {
        Pop,
        Science,
        Sports,
        Rock
    }
}
