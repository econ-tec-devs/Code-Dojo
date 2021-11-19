using System;

namespace KataTicTacToe_20211021
{
    public class TicTacToe
    {
        public string Initialize()
        {
            return "         ";
        }

        public string Move(string inputValidCoordinate)
        {
            var grid = string.Empty;
            int x = GetX(inputValidCoordinate);
            int y = GetY(inputValidCoordinate);
            var index = x + (y*3);
            string before = new string(' ', index);
            string after = new string(' ',8-index);
            return $"{before}X{after}";
         
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