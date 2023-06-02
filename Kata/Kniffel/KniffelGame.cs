namespace Kniffel;

public class KniffelGame
{
    public int[] Dice()
    {
        var random = new Random();
        var result = new int[5];
        for (var i = 0; i < 5; i++) result[i] = random.Next(1, 6);

        return result;
    }
}