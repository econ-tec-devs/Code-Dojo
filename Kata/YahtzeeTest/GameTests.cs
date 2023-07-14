using Yahtzee;
namespace YahtzeeTest;

public class GameTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Dice_Called_Passes()
    {
        // Arrange
        var sut = new Game();
        
        // Act
        sut.Dice();
        
        // Assert
        Assert.Pass();
    }
    
    [Test]
    public void Dice_Called_ReturnFiveNumbers()
    {
        // Arrange
        var sut = new Game();
        
        // Act
        int[] actual = sut.Dice();
        
        // Assert
        Assert.That(actual, Is.TypeOf<int[]>());
        Assert.That(actual.Length, Is.EqualTo(5));
    }
    
    [Test]
    public void Dice_Called_ReturnNumbersBetweenOneAndSix()
    {
        // Arrange
        var sut = new Game();
        
        // Act
        int[] actual = sut.Dice();
        
        // Assert
        Assert.That(actual, Is.All.InRange(1,6));
    }
}