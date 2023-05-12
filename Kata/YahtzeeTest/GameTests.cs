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
}