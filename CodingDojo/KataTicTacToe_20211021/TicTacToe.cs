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
            if (inputValidCoordinate == "B0")
            {
                return " X       ";
            }
            return "X        ";
        }
    }
}