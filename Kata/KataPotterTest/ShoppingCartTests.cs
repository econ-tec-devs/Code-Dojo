namespace KataPotterTest;

public class ShoppingCartTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Checkout_Called_Passed()
    {
        //Arrange
        var sut = new ShoppingCart(); 
        //Act
        sut.Checkout();
        //Assert
        Assert.Pass();
    }
}