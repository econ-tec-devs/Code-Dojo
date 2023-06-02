using Kniffel;
namespace KniffelTest;

public class KniffelGameTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Dice_Called_Passed()
    {
        // Arrange
        var sut = new KniffelGame();

        // Act
        sut.Dice();

        // Assert
        Assert.Pass();
    }
    
    [Test]
    public void Dice_Called_ReturnFiveNumbers()
    {
        // Arrange
        var sut = new KniffelGame();
        int[] expected = new[] { 0, 0, 0, 0, 0 };
        
        // Act
        int[] actual = sut.Dice();
        
        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
    
    [Test]
    public void Dice_Called_NumbersBiggerThan0()
    {
        // Arrange
        var sut = new KniffelGame();
        int[] expected = new[] { 0, 0, 0, 0, 0 };
        
        // Act
        int[] actual = sut.Dice();
        
        // Assert
        foreach (var i in actual)
        {
           Assert.That(i, Is.GreaterThan(0)); 
           
        }
    }
}

