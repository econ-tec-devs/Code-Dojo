namespace Kniffel;

public class KniffelGame
{
    private int[] _previousRoll = {0,0,0,0,0};
    
    public int[] Dice(string reroll = "true;true;true;true;true")
    {
        var rerollDice = reroll.Split(';');
        var rerollDiceBool = new bool[5];
        for (var i = 0; i < rerollDice.Length; i++)
        {
            rerollDiceBool[i] = rerollDice[i] == "true";
        }

        var random = new Random();
        var result = (int[])_previousRoll.Clone();
        for (var i = 0; i < 5; i++)
        {
            if (rerollDiceBool[i])
            {
                result[i] = random.Next(1, 6);
            }
        }

        _previousRoll = result;
        
        return result;
    }
}