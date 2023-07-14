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
}