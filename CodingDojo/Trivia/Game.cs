using System;
using System.Collections.Generic;
using System.Linq;

namespace Trivia
{
    public class Game
    {
        private readonly List<string> _players = new List<string>();

        private readonly int[] _places = new int[_maxPlayerCount];

        private readonly int[] _purses = new int[_maxPlayerCount];

        private readonly bool[] _inPenaltyBox = new bool[_maxPlayerCount];

        private readonly LinkedList<string> _popQuestions = new LinkedList<string>();
        
        private readonly LinkedList<string> _scienceQuestions = new LinkedList<string>();
        
        private readonly LinkedList<string> _sportsQuestions = new LinkedList<string>();
        
        private readonly LinkedList<string> _rockQuestions = new LinkedList<string>();

        private int _currentPlayer;
        
        private bool _isGettingOutOfPenaltyBox;
        
        private static int _maxPlayerCount = 6;

        private int _minPlayerCount = 2;

        private int _maxQuestionCount = 50;

        private int _maxPlacesCount = 12;

        public Game()
        {
            for (var i = 0; i < _maxQuestionCount; i++)
            {
                _popQuestions.AddLast("Pop Question " + i);
                _scienceQuestions.AddLast(("Science Question " + i));
                _sportsQuestions.AddLast(("Sports Question " + i));
                _rockQuestions.AddLast(CreateRockQuestion(i));
            }
        }

        public string CreateRockQuestion(int index)
        {
            return "Rock Question " + index;
        }

        public bool IsPlayable()
        {
            return (HowManyPlayers() >= _minPlayerCount);
        }

        public bool Add(string playerName)
        {
            _players.Add(playerName);
            
            Console.WriteLine(playerName + " was added");
            Console.WriteLine("They are player number " + _players.Count);
            return true;
        }

        public int HowManyPlayers()
        {
            return _players.Count;
        }

        public void Roll(int roll)
        {
            Console.WriteLine(_players[_currentPlayer] + " is the current player");
            Console.WriteLine("They have rolled a " + roll);

            if (_inPenaltyBox[_currentPlayer])
            {
                if (roll % 2 != 0)
                {
                    _isGettingOutOfPenaltyBox = true;

                    Console.WriteLine(_players[_currentPlayer] + " is getting out of the penalty box");
                    _places[_currentPlayer] = _places[_currentPlayer] + roll;
                    if (_places[_currentPlayer] > 11)
                    {
                        _places[_currentPlayer] = _places[_currentPlayer] - _maxPlacesCount;
                    }

                    Console.WriteLine(_players[_currentPlayer]
                            + "'s new location is "
                            + _places[_currentPlayer]);
                    Console.WriteLine("The category is " + CurrentCategory());
                    AskQuestion();
                }
                else
                {
                    Console.WriteLine(_players[_currentPlayer] + " is not getting out of the penalty box");
                    _isGettingOutOfPenaltyBox = false;
                }
            }
            else
            {
                _places[_currentPlayer] = _places[_currentPlayer] + roll;
                if (_places[_currentPlayer] > 11)
                {
                    _places[_currentPlayer] = _places[_currentPlayer] - _maxPlacesCount;
                }

                Console.WriteLine(_players[_currentPlayer]
                        + "'s new location is "
                        + _places[_currentPlayer]);
                Console.WriteLine("The category is " + CurrentCategory());
                AskQuestion();
            }
        }

        private void AskQuestion()
        {
            if (CurrentCategory() == "Pop")
            {
                Console.WriteLine(_popQuestions.First());
                _popQuestions.RemoveFirst();
            }
            if (CurrentCategory() == "Science")
            {
                Console.WriteLine(_scienceQuestions.First());
                _scienceQuestions.RemoveFirst();
            }
            if (CurrentCategory() == "Sports")
            {
                Console.WriteLine(_sportsQuestions.First());
                _sportsQuestions.RemoveFirst();
            }
            if (CurrentCategory() == "Rock")
            {
                Console.WriteLine(_rockQuestions.First());
                _rockQuestions.RemoveFirst();
            }
        }

        private string CurrentCategory()
        {
            switch (_places[_currentPlayer])
            {
                case 0:
                case 4:
                case 8:
                    return "Pop";
                case 1:
                case 5:
                case 9:
                    return "Science";
                case 2:
                case 6:
                case 10:
                    return "Sports";
                default:
                    return "Rock";
            }
        }

        public bool WasCorrectlyAnswered()
        {
            var winner = DidPlayerWin();
            if (_inPenaltyBox[_currentPlayer])
            {
                if (_isGettingOutOfPenaltyBox)
                {
                    Console.WriteLine("Answer was correct!!!!");
                    _purses[_currentPlayer]++;
                    Console.WriteLine(_players[_currentPlayer]
                            + " now has "
                            + _purses[_currentPlayer]
                            + " Gold Coins.");

                    _currentPlayer++;
                    if (_currentPlayer == _players.Count)
                    {
                        _currentPlayer = 0;
                    }

                    return winner;
                }

                _currentPlayer++;
                if (_currentPlayer == _players.Count)
                {
                    _currentPlayer = 0;
                }

                return true;
            }

            Console.WriteLine("Answer was corrent!!!!");
            _purses[_currentPlayer]++;
            Console.WriteLine(_players[_currentPlayer]
                              + " now has "
                              + _purses[_currentPlayer]
                              + " Gold Coins.");

            winner = DidPlayerWin();
            _currentPlayer++;
            if (_currentPlayer == _players.Count)
            {
                _currentPlayer = 0;
            }

            return winner;
        }

        public bool WrongAnswer()
        {
            Console.WriteLine("Question was incorrectly answered");
            Console.WriteLine(_players[_currentPlayer] + " was sent to the penalty box");
            _inPenaltyBox[_currentPlayer] = true;

            _currentPlayer++;
            if (_currentPlayer == _players.Count)
            {
                _currentPlayer = 0;
            }

            return true;
        }


        private bool DidPlayerWin()
        {
            return _purses[_currentPlayer] != 6;
        }
    }

}
