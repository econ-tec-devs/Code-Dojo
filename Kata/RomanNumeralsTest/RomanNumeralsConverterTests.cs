using RomanNumerals;

namespace RomanNumeralsTest;

public class RomanNumeralsConverterTests
{
    [TestCase(1, "I")]
    [TestCase(2, "II")]
    [TestCase(3, "III")]
    [TestCase(4, "IV")]
    [TestCase(5, "V")]
    public void ToRoman_Input3_ReturnsIII(int input, string expected)
    {
        // Arrange
        var sut = new RomanNumeralsConverter();

        // Act
        var actual = sut.ToRoman(input);
        
        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}