using Yahtzee;

namespace YahtzeeTest;

public class GameTests
{
    private Game _sut;

    [SetUp]
    public void Setup()
    {
        _sut = new Game();
    }

    [Test]
    public void RollDice_Called_ReturnFiveNumbers()
    {
        // Arrange 
        var expected = new int[5];

        //Act
        var actual = _sut.RollDice();

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void RollDice_Called_ReturnNumbersAreBetween1And6()
    {
        // Arrange 
        var expected = new int[5];

        //Act
        var actual = _sut.RollDice();

        // Assert
        foreach (var i in actual) Assert.That(i, Is.GreaterThan(1).And.LessThanOrEqualTo(6));
    }
}