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
        // Arrange & Act
        var actual = _sut.RollDice();

        // Assert
        Assert.That(actual.Length, Is.EqualTo(5));
        Assert.That(actual, Is.TypeOf<int[]>());
    }

    [Test]
    public void RollDice_Called_ReturnNumbersAreBetween1And6()
    {
        // Arrange & Act 
        var actual = _sut.RollDice();

        // Assert
        foreach (var i in actual) Assert.That(i, Is.GreaterThanOrEqualTo(1).And.LessThanOrEqualTo(6));
    }
    
    [TestCase(Category.LargeStraight, 40)]
    [TestCase(Category.SmallStraight, 30)]
    [TestCase(Category.FullHouse, 25)]
    public void PlaceRollToCategory_InputRollAndSmallStraight_Returns30(Category category, int expected)
    {
        // Arrange & Act
        var actual = _sut.PlaceRollToCategory(new[] { 1, 2, 3, 4, 5 }, category);
        
        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
    
    
}