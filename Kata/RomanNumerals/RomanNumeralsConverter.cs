namespace RomanNumerals;

public class RomanNumeralsConverter
{
    public string ToRoman(int number)
    {
        var output = string.Empty; 
        
        if (number == 4)
        {
            return "IV";
        }
        
        for (var i = 1; i <= number; i++)
        {
            output += "I";
        }
        
        return output;
    }
}