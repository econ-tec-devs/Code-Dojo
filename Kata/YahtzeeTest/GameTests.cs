using Yahtzee;

namespace YahtzeeTest;

public class GameTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Ctor_Called_Pass()
    {
        // Arrange & Act
        var sut = new Game();

        // Assert
        Assert.Pass();
    }

    [Test]
    public void RollDice_Called_ReturnFiveNumbers()
    {
        // Arrange 
        var sut = new Game();
        int[] expected = new int[5];

        //Act
        int[] actual = sut.RollDice();
        
        // Assert
        Assert.That(actual, Is.EqualTo(expected));

    }
}