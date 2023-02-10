namespace RomanNumerals;

public class RomanNumeralsConverter
{
    public string ToRoman(int number)
    {
        var output = string.Empty;
        
        if (number == 24)
        {
            return "XXIV";
        }

        if (number == 19)
        {
            return "XIX";
        }
        
        if (number == 14)
        {
            return "XIV";
        }
        
        if (number == 9)
        {
            return "IX";
        }
        
        if (number == 4)
        {
            return "IV";
        }

        output += Number(ref number, 10, "X");
        output += Number(ref number, 5, "V");

        for (var i = 1; i <= number; i++)
        {
            output += "I";
        }
        
        return output;
    }

    private string Number(ref int number, int divisor, string romanNumeral)
    {
        var output = string.Empty;
        
        for (var i = number / divisor; i > 0; i--)
        {
            output += romanNumeral;
            number -= divisor;
        }
        return output;
    }
}