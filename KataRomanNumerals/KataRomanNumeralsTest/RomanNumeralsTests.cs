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
}