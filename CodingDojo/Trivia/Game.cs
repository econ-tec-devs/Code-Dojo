using System.Collections.Generic;
using System.Linq;

namespace Trivia
{
    public class Game
    {
        private List<string> _players = new List<string>();

        public string createRockQuestion(int i)
        {
            return $"Rock Question {i}";
        }

        public void add(string playerName)
        {
            _players.Add(playerName);
        }

        public int howManyPlayers()
        {
            return _players.Count();
        }
    }
}
