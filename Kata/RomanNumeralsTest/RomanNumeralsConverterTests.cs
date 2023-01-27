using RomanNumerals;

namespace RomanNumeralsTest;

public class RomanNumeralsConverterTests
{
    [TestCase(1, "I")]
    [TestCase(2, "II")]
    [TestCase(3, "III")]
    [TestCase(4, "IV")]
    [TestCase(5, "V")]
    [TestCase(6, "VI")]
    [TestCase(7, "VII")]
    
    
    public void ToRoman_InputNumbers_ReturnsRomanNumerals(int input, string expected)
    {
        // Arrange
        var sut = new RomanNumeralsConverter();

        // Act
        var actual = sut.ToRoman(input);
        
        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}