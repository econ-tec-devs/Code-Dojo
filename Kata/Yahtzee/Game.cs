namespace Yahtzee;

public class Game
{
    public int[] RollDice()
    {
        var rnd = new Random();
        var dice = new int[5];

        for (var i = 0; i < 5; i++)
        {
            var number = rnd.Next(1, 6);
            dice[i] = number;
        }

        return dice;
    }

    public int PlaceRollToCategory()
    {
        return 0;
    }
}