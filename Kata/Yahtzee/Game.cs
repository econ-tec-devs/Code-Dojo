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
            Categories.Pair => SumHighestPairs(dice, 1),
            Categories.TwoPairs => SumHighestPairs(dice, 2),
            Categories.ThreeOfAKind => CountOfAKind(dice, 3),
            Categories.FourOfAKind => CountOfAKind(dice, 4),
            _ => throw new ArgumentOutOfRangeException(nameof(category), category, null)
        };
    }

    private int CountOfAKind(int[] dice, int countOfAKind)
    {
        return dice.GroupBy(number => number)
            .Where(number => number.Count() >= countOfAKind)
            .Sum(number => number.Key * countOfAKind);
    }
  

    private int SumHighestPairs(int[] dice, int pairs)
    {
        var filteredDice  = dice.GroupBy(number => number)
            .Where(number => number.Count() > 1)
            .ToList();

        if (filteredDice.Count < pairs)
        {
            return 0;
        }
        
        return filteredDice
            .OrderByDescending(number => number.First())
            .Take(pairs)
            .Sum(number => number.Key * 2);
    }

    private int SumOnesTillSixes(int[] dice, int category) 
        => dice.Count(cube => cube == category) * category;
    
}
