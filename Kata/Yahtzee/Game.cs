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
            Categories.Twos => SumOnesTillSixes(dice, 2),
            Categories.Threes => SumOnesTillSixes(dice, 3),
            Categories.Fours => SumOnesTillSixes(dice, 4),
            Categories.Fives => SumOnesTillSixes(dice, 5),
            Categories.Sixes => SumOnesTillSixes(dice, 6),
            Categories.Pair => SumOfTheHighestPair(dice),
            Categories.TwoPairs => SumHighestTwoPairs(dice),
            _ => throw new ArgumentOutOfRangeException(nameof(category), category, null)
        };
    }

    private int SumHighestTwoPairs(int[] dice)
    {
        var filteredDice  = dice.GroupBy(number => number)
            .Where(number => number.Count() > 1)
            .ToList();

        if (filteredDice.Count < 2)
        {
            return 0;
        }
        
        return filteredDice
            .OrderByDescending(number => number.First())
            .Take(2)
            .Sum(number => number.Key * number.Count());
    }

    private int SumOfTheHighestPair(int[] dice)
    {
        var enumerable = dice.GroupBy(number => number)
            .Where(number => number.Count() > 1).ToList();
        if (!enumerable.Any() )
        {
            return 0;
        }
        return enumerable
            .OrderByDescending(number => number.First())
            .First()
            .Key * 2;
    }

    private int SumOnesTillSixes(int[] dice, int category) 
        => dice.Count(cube => cube == category) * category;
    
}

