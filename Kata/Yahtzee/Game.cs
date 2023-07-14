namespace Yahtzee;

public class Game
{
    public int[] Dice(int amount = 5)
    {
        var result = new int[amount];
        
        for (var i = 0; i < amount; i++)
        {
            var random = new Random();
            result[i] = random.Next(1, 6); 
        }

        return result;
    }

    public int PlaceRoll(int[] dice, Categories category)
    {
        // var result = 0;
        // foreach (var cube in dice)
        // {
        //     if (cube == 1)
        //     {
        //         result += 1;
        //     }
        // }
        //
        // return result;

        return category switch
        {
            Categories.Ones => SumOnesTillSixes(dice, 1),
            Categories.Twoes => SumOnesTillSixes(dice, 2),
            Categories.Threes => SumOnesTillSixes(dice, 3),
            Categories.Fours => SumOnesTillSixes(dice, 4),
            Categories.Fives => SumOnesTillSixes(dice, 5),
            Categories.Sixes => SumOnesTillSixes(dice, 6),
            _ => throw new ArgumentOutOfRangeException(nameof(category), category, null)
        };
    }

    private static int SumOnesTillSixes(int[] dice, int category)
    {
        return dice.Count(cube => cube == category) * category;
    }
}