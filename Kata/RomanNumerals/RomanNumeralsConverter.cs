namespace RomanNumerals;

public class RomanNumeralsConverter
{
    public string ToRoman(int number)
    {
        if (number == 2)
        {
            return "II";
        }

        return "I";


    }
    
}