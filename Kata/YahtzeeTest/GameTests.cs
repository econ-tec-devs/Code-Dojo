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
        Assert.That(actual.Length, Is.EqualTo(5));
        Assert.That(actual, Is.TypeOf<int[]>());
    }

    [Test]
    public void RollDice_Called_ReturnNumbersAreBetween1And6()
    {
        // Arrange 
        var expected = new int[5];

        //Act
        var actual = _sut.RollDice();

        // Assert
        foreach (var i in actual) Assert.That(i, Is.GreaterThanOrEqualTo(1).And.LessThanOrEqualTo(6));
    }

    [Test]
    public void PlaceRollToCategory_RollIsCompatibleWithCategory_ReturnScore()
    {
        //Act
        var actual = _sut.PlaceRollToCategory();

        // Assert
        Assert.That(actual, Is.TypeOf<int>());
    }
}