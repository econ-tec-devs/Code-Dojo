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
    public void Dice_Called_ReturnsFiveNumbers()
    {
        // Arrange
        var sut = new KniffelGame();

        // Act
        var actual = sut.Dice();

        // Assert
        Assert.That(actual, Is.TypeOf<int[]>());
        Assert.That(actual, Has.Length.EqualTo(5));
    }

    [Test]
    public void Dice_Called_ReturnsNumbersBiggerThan0()
    {
        // Arrange
        var sut = new KniffelGame();

        // Act
        var actual = sut.Dice();

        // Assert
        foreach (var i in actual) Assert.That(i, Is.GreaterThan(0));
    }

    [Test]
    public void Dice_Called_ReturnsNumbersLessThan7()
    {
        // Arrange
        var sut = new KniffelGame();

        // Act
        var actual = sut.Dice();

        // Assert
        foreach (var i in actual) Assert.That(i, Is.LessThan(7));
    }

    [Test]
    public void Dice_CalledTwice_ReturnsDifferentNumbers()
    {
        // Arrange
        var sut = new KniffelGame();

        // Act
        var actual1 = sut.Dice();
        var actual2 = sut.Dice();

        // Assert
        Assert.That(actual1, Is.Not.EqualTo(actual2));
    }

    [Test]
    public void Dice_CalledTwiceSecondRollOnlyWithTwoLastDice_ReturnsFirst3EqualLast2Not()
    {
        // Arrange
        var sut = new KniffelGame();

        // Act
        var actual1 = sut.Dice();
        var actual2 = sut.Dice("false;false;false;true;true");

        // Assert
        Assert.That(actual1[0], Is.EqualTo(actual2[0]));
        Assert.That(actual1[1], Is.EqualTo(actual2[1]));
        Assert.That(actual1[2], Is.EqualTo(actual2[2]));
        Assert.That(actual1[3], Is.Not.EqualTo(actual2[3]));
        Assert.That(actual1[4], Is.Not.EqualTo(actual2[4]));
    }
}