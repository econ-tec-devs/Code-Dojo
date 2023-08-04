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
        return category switch
        {
            Categories.Ones => SumOnesTillSixes(dice, 1),
            Categories.Twoes => SumOnesTillSixes(dice, 2),
            Categories.Threes => SumOnesTillSixes(dice, 3),
            Categories.Fours => SumOnesTillSixes(dice, 4),
            Categories.Fives => SumOnesTillSixes(dice, 5),
            Categories.Sixes => SumOnesTillSixes(dice, 6),
            Categories.Pair => SumOfTheHighestPair(dice),
            _ => throw new ArgumentOutOfRangeException(nameof(category), category, null)
        };
    }

    private int SumOfTheHighestPair(int[] dice)
    {
        var groupNumbers = dice.GroupBy(number => number);
        var test = groupNumbers.Where(number => number.Count()>1).OrderByDescending(number => number.First()).First().Key;
        return test*2;
    }

    private int SumOnesTillSixes(int[] dice, int category) 
        => dice.Count(cube => cube == category) * category;
    
}

