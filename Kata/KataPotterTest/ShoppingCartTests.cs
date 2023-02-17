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
    public void Checkout_InputStringList_Passed()
    {
        //Arrange
        var sut = new ShoppingCart();
        var books = new List<string>();
        //Act
        sut.Checkout(books);
        //Assert
        Assert.Pass();
        
    }[Test]
    public void Checkout_InputEmptyStringList_ReturnPriceDecimal()
    {
        //Arrange
        var sut = new ShoppingCart();
        var books = new List<string>();
        //Act
        decimal price = sut.Checkout(books);
        //Assert
        Assert.That(price, Is.EqualTo(0));
    }
}


