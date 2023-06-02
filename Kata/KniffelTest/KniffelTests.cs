namespace KniffelTest;

public class KniffelTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Dice_Called_Passed()
    {
        // Arrange
        var sut = new Kniffel();

        // Act
        sut.Dice();

        // Assert
        Assert.Pass();
    }
}