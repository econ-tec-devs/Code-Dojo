namespace RomanNumerals;

public class RomanNumeralsConverter
{
    public string ToRoman(int number)
    {
        var output = string.Empty; 
        for (var i = number; i > 0; i--)
        {
            output += "I";
        }
        
        return output;
    }
    
}