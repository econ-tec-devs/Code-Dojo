using KataRomanNumerals;
namespace KataRomanNumeralsTest;

public class RomanNumeralsTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void GetNumbers_Call_Pass()
    {
        // Arrange
        var sut = new RomanNumerals();
       
        // Act

        sut.GetNumbers();
        
        // Assert
        Assert.Pass();
    }
    
    [Test]
    public void GetNumbers_Input1_ReturnI()
    {
        // Arrange
        var sut = new RomanNumerals();
        var expected = "I";
       
        // Act
        var actual = sut.GetNumbers(1);
        
        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}