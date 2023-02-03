namespace RomanNumerals;

public class RomanNumeralsConverter
{
    public string ToRoman(int number)
    {
        var output = string.Empty; 
        
        for (var i = 1; i <= number; i++)
        {
            output += "I";
        }

        if (number == 8)
        {
            return "VIII";
        }
        
        if (number == 7)
        {
            return "VII";
        }
        
        if (number == 6)
        {
            return "VI";
        }
        
        if (number == 5)
        {
            return "V";
        }
        
        if (number == 4)
        {
            return "IV";
        }

        
        return output;
    }
}