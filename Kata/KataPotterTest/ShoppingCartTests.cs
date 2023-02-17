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
        sut.Checkout(null);
        //Assert
        Assert.Pass();
    }
    
    [Test]
    public void Checkout_InputStringArray_Passed()
    {
        //Arrange
        var sut = new ShoppingCart();
        List<string> books = new List<string>();
        //Act
        sut.Checkout(books);
        //Assert
        Assert.Pass();
    }
}