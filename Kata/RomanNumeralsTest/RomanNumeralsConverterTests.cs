using RomanNumerals;

namespace RomanNumeralsTest;

public class RomanNumeralsConverterTests
{
    private RomanNumeralsConverter sut;
    [SetUp]
    public void Setup()
    {
        sut = new RomanNumeralsConverter(); 
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
        
        var expected = "II";
        
        // Act
        string actual = sut.ToRoman(2);
        
        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
    [Test]
    public void ToRoman_Input3_ReturnsIII()
    {
        // Arange
        
        var expected = "III";
        
        // Act
        string actual = sut.ToRoman(3);
        
        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}