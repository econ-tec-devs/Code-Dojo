using System;
using System.Collections.Generic;
using System.Linq;

namespace TriviaConsole
{
    public class Game
    {
        private List<string> _players = new List<string>();
        private int _maxPlayer = 5;

        public string createRockQuestion(int i)
        {
            return $"Rock Question {i}";
        }

        public void add(string playerName)
        {
            if (_players.Count() == _maxPlayer)
            {
                throw new IndexOutOfRangeException();
            }

            _players.Add(playerName);
            Console.Write($"{playerName} was added{Environment.NewLine}They are player number {_players.Count}{Environment.NewLine}");
        }

        public int howManyPlayers()
        {
            return _players.Count();
        }

        public bool isPlayable()
        {
            return _players.Count > 1;
        }
    }
}
