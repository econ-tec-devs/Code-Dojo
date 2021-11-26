using System;
using System.Linq;

namespace KataTicTacToe_20211021
{
    public class TicTacToe
    {
        private string _board;

        public string Board => _board;

        public TicTacToe()
        {
            _board = Initialize();
        }

        private string Initialize()
        {
            return "         ";
        }

        public string Move(string coordinate)
        {
            var index = GetIndex(coordinate);
            if (IsInvalidMove(index)) return _board;
            var before = _board.Substring(0, index);
            var after = _board.Substring(index,8-index);
            var player = GetCurrentPlayer();
            
            return _board = $"{before}{player}{after}";
        }

        private bool IsInvalidMove(int index)
            => _board[index] != ' ';

        private string GetCurrentPlayer()
        {
            var countX = _board.Count(x => x.Equals('X'));
            var countO = _board.Count(x => x.Equals('O'));

            return countX == countO ? "X" : "O";
        }

        private int GetIndex(string coordinate) 
            => GetX(coordinate) + (GetY(coordinate) * 3);

        private int GetX(string inputValidCoordinate) 
            => "ABC".IndexOf(inputValidCoordinate[0]);

        private int GetY(string inputValidCoordinate) 
            => Convert.ToInt32(inputValidCoordinate[1].ToString());
    }
}
