namespace RomanNumerals;

public class RomanNumeralsConverter
{
    public string ToRoman(int number)
    {
        var output = string.Empty;
        output += Number(ref number, 1000, "M");
        output += Number(ref number, 900, "CM");
        output += Number(ref number, 500, "D");
        output += Number(ref number, 400, "CD");
        output += Number(ref number, 100, "C");
        output += Number(ref number, 90, "XC");
        output += Number(ref number, 50, "L");
        output += Number(ref number, 40, "XL");
        output += Number(ref number, 10, "X");
        output += Number(ref number, 9, "IX");
        output += Number(ref number, 5, "V");
        output += Number(ref number, 4, "IV");

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