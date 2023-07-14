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
        return category switch
        {
            // foreach (var cube in dice)
            // {
            //     if (cube == 1)
            //     {
            //         result += 1;
            //     }
            // }
            //
            // return result;
            
            Categories.Ones => dice.Count(cube => cube == 1) * 1, // same but shorter
            Categories.Fours => dice.Count(cube => cube == 4) * 4, // same but shorter
            _ => throw new ArgumentOutOfRangeException(nameof(category), category, null)
        };
    }
}