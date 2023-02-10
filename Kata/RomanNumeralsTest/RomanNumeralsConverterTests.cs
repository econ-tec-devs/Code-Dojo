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
    [TestCase(8, "VIII")]
    [TestCase(9, "IX")] 
    [TestCase(10, "X")]
    [TestCase(11, "XI")]
    [TestCase(12, "XII")]
    [TestCase(13, "XIII")]
    [TestCase(14, "XIV")]
    [TestCase(15, "XV")]
    [TestCase(16, "XVI")]
    [TestCase(17, "XVII")]
    [TestCase(18, "XVIII")]
    [TestCase(19, "XIX")]
    [TestCase(20, "XX")]
    [TestCase(21, "XXI")]
    [TestCase(22, "XXII")]
    [TestCase(23, "XXIII")]
    [TestCase(24, "XXIV")]
    [TestCase(25, "XXV")]
    [TestCase(26, "XXVI")]
    [TestCase(29, "XXIX")]
    [TestCase(30, "XXX")]
    [TestCase(31, "XXXI")]
    [TestCase(34, "XXXIV")]
    [TestCase(35, "XXXV")]
    [TestCase(36, "XXXVI")]
    [TestCase(39, "XXXIX")]
    [TestCase(40, "XL")]
    [TestCase(41, "XLI")]
    [TestCase(44, "XLIV")]
    [TestCase(45, "XLV")]
    [TestCase(50, "L")]
    [TestCase(51, "LI")]
    [TestCase(54, "LIV")]
    [TestCase(60, "LX")]
    [TestCase(90, "XC")]
    [TestCase(100, "C")]
    [TestCase(399, "CCCXCIX")]
    [TestCase(400, "CD")]
    [TestCase(500, "D")]
    [TestCase(756, "DCCLVI")]
    [TestCase(900, "CM")]
    [TestCase(1000, "M")]
    [TestCase(1982, "MCMLXXXII")]
    [TestCase(1995, "MCMXCV")]
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