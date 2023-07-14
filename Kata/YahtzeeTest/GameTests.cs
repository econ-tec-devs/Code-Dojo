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
    [TestCase(new [] {1, 1, 2, 4, 4}, Categories.Twoes, 2)]
    [TestCase(new [] {1, 1, 2, 4, 4}, Categories.Three, 0)]
    [TestCase(new [] {1, 1, 2, 4, 4}, Categories.Fours, 8)]
    public void PlaceRoll_Input11244OnOnes_Return2(int[] dice, Categories category, int expected)
    {
        // Act
        var actual = _sut.PlaceRoll(dice, category);
        
        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}