using RomanNumerals;

namespace RomanNumeralsTest;

public class RomanNumeralsConverterTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Ctor_Called_Passes()
    {
        new RomanNumeralsConverter();
        
        Assert.Pass();
    }
    
    [Test]
    public void ToRoman_Input1_ReturnsI()
    {
        // Arange
        var sut = new RomanNumeralsConverter();
        var expected = "I";
        
        // Act
        string actual = sut.ToRoman(1);
        
        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    } 
    [Test]
    public void ToRoman_Input2_ReturnsII()
    {
        // Arange
        var sut = new RomanNumeralsConverter();
        var expected = "II";
        
        // Act
        string actual = sut.ToRoman(2);
        
        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}