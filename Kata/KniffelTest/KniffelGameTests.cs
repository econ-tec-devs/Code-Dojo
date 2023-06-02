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
}