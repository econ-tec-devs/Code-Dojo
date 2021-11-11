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
            string before = new string(' ',x);
            string after = new string(' ',8-x);
            return $"{before}X{after}";
         
        }

        private int GetX(string inputValidCoordinate)
        {
            return "ABC".IndexOf(inputValidCoordinate[0]);
        }
    }
}