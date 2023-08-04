using Yahtzee;
namespace YahtzeeTest;

public class GameTests
{
    private Game _sut = new();

    [SetUp]
    public void Setup()
    {
        _sut = new Game();
    }

    [Test]
    public void Dice_Called_Passes()
    {
        // Act
        _sut.Dice();
        
        // Assert
        Assert.Pass();
    }
    
    [Test]
    public void Dice_Called_ReturnFiveNumbers()
    {
        // Act
        var actual = _sut.Dice();
        
        // Assert
        Assert.That(actual, Is.TypeOf<int[]>());
        Assert.That(actual.Length, Is.EqualTo(5));
    }
    
    [Test]
    public void Dice_Called_ReturnNumbersBetweenOneAndSix()
    {
        // Act
        var actual = _sut.Dice();
        
        // Assert
        Assert.That(actual, Is.All.InRange(1,6));
    }
    
    [Test]
    public void Dice_InputThree_ReturnThreeNumbers()
    {
        // Act
        var actual = _sut.Dice(3);
        
        // Assert
        Assert.That(actual.Length, Is.EqualTo(3));
    }

    [TestCase(new [] {1, 1, 2, 4, 4}, Categories.Ones, 2)]
    [TestCase(new [] {2, 2, 2, 4, 4}, Categories.Ones, 0)]
    [TestCase(new [] {1, 1, 2, 4, 4}, Categories.Twos, 2)]
    [TestCase(new [] {1, 1, 3, 4, 4}, Categories.Twos, 0)]
    [TestCase(new [] {3, 3, 2, 4, 4}, Categories.Threes, 6)]
    [TestCase(new [] {1, 1, 2, 4, 4}, Categories.Threes, 0)]
    [TestCase(new [] {1, 1, 2, 4, 4}, Categories.Fours, 8)]
    [TestCase(new [] {1, 1, 2, 3, 3}, Categories.Fours, 0)]
    [TestCase(new [] {1, 1, 2, 5, 5}, Categories.Fives, 10)]
    [TestCase(new [] {1, 1, 2, 4, 4}, Categories.Fives, 0)]
    [TestCase(new [] {1, 1, 2, 6, 6}, Categories.Sixes, 12)]
    [TestCase(new [] {1, 1, 2, 4, 4}, Categories.Sixes, 0)]
    [TestCase(new [] {3, 3, 3, 4, 4}, Categories.Pair, 8)]
    [TestCase(new [] {3, 3, 6, 4, 4}, Categories.Pair, 8)]
    [TestCase(new [] {5, 5, 6, 4, 4}, Categories.Pair, 10)]
    [TestCase(new [] {5, 5, 5, 4, 4}, Categories.Pair, 10)]
    [TestCase(new [] {1, 2, 3, 4, 5}, Categories.Pair, 0)]
    [TestCase(new [] {1, 1, 2, 3, 3}, Categories.TwoPairs, 8)]
    [TestCase(new [] {4, 4, 2, 3, 3}, Categories.TwoPairs, 14)]
    // [TestCase(new [] {1, 2, 3, 4, 4}, Categories.TwoPairs, 0)]
    // [TestCase(new [] {1, 2, 3, 4, 5}, Categories.TwoPairs, 0)]
    public void PlaceRoll_InputDiceAndCategory_ReturnPoints(int[] dice, Categories category, int expected)
    {
        // Act
        var actual = _sut.PlaceRoll(dice, category);
        
        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}