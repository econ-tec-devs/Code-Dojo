namespace Kniffel;

public class KniffelGame
{
    private readonly int[] _previousRoll = {0,0,0,0,0};
    
    public int[] Dice(string reroll = "true;true;true;true;true")
    {
        var rerollDice = reroll.Split(';');
        for (var i = 0; i < 5; i++)
        {
            if (rerollDice[i] == "true")
            {
                _previousRoll[i] = new Random().Next(1, 6);
            }
        }

        return (int[])_previousRoll.Clone();
    }
}