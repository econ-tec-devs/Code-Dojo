using Kniffel;

namespace KniffelTest;

public class KniffelGameTests
{
    private KniffelGame _sut;

    [SetUp]
    public void Setup()
    {
        _sut = new KniffelGame();
    }

    [Test]
    public void Dice_Called_Passed()
    {
        // Act
        _sut.Dice();

        // Assert
        Assert.Pass();
    }

    [Test]
    public void Dice_Called_ReturnsFiveNumbers()
    {
        // Act
        var actual = _sut.Dice();

        // Assert
        Assert.That(actual, Is.TypeOf<int[]>());
        Assert.That(actual, Has.Length.EqualTo(5));
    }

    [Test]
    public void Dice_Called_ReturnsNumbersBiggerThan0()
    {
        // Act
        var actual = _sut.Dice();

        // Assert
        foreach (var i in actual) Assert.That(i, Is.GreaterThan(0));
    }

    [Test]
    public void Dice_Called_ReturnsNumbersLessThan7()
    {
        // Act
        var actual = _sut.Dice();

        // Assert
        foreach (var i in actual) Assert.That(i, Is.LessThan(7));
    }

    [Test]
    public void Dice_CalledTwice_ReturnsDifferentNumbers()
    {
        // Act
        var actual1 = _sut.Dice();
        var actual2 = _sut.Dice();

        // Assert
        Assert.That(actual1, Is.Not.EqualTo(actual2));
    }

    [Test]
    public void Dice_CalledTwiceSecondRollOnlyWithTwoLastDice_ReturnsFirst3EqualLast2Not()
    {
        // Act
        var actual1 = _sut.Dice();
        var actual2 = _sut.Dice("false;false;false;true;true");

        // Assert
        Assert.That(actual1[0], Is.EqualTo(actual2[0]));
        Assert.That(actual1[1], Is.EqualTo(actual2[1]));
        Assert.That(actual1[2], Is.EqualTo(actual2[2]));
        Assert.That(actual1[3], Is.Not.EqualTo(actual2[3]));
        Assert.That(actual1[4], Is.Not.EqualTo(actual2[4]));
    }
}