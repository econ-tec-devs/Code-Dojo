namespace Yahtzee;

public class Game
{
    public int[] Dice()
    {
        var result = new int[5];
        for (var i = 0; i < 5; i++)
        {
            var random = new Random();
            result[i] = random.Next(1, 6); 
        }

        return result;
    }
}