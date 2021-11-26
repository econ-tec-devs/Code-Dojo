using System;

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

        public string Move(string inputValidCoordinate)
        {
            var x = GetX(inputValidCoordinate);
            var y = GetY(inputValidCoordinate);
            var index = x + (y*3);
            var before = _board.Substring(0, index);
            var after = _board.Substring(index,8-index);
            if (_board.Contains('X'))
            {
               return _board = $"{before}O{after}";
            }
            return _board = $"{before}X{after}";
        }

        private int GetX(string inputValidCoordinate)
        {
            return "ABC".IndexOf(inputValidCoordinate[0]);
        }
        private int GetY(string inputValidCoordinate)
        {
            return Convert.ToInt32(inputValidCoordinate[1].ToString());
        }
    }
}
