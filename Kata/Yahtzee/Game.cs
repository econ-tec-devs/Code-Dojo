namespace Yahtzee;

public class Game
{
    public int[] RollDice()
    {
        
        Random rnd = new Random();
        var dice = new int[5];
        
        for (int i = 0; i < 5; i++)
        {
            int number = rnd.Next(1, 6);
            dice[i] = number;
        }
        
        return dice;
    }
}