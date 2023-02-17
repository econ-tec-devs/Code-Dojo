namespace KataPotterTest;

public class ShoppingCartTests
{
    private ShoppingCart sut;

    [SetUp]
    public void Setup()
    { 
        sut = new ShoppingCart(); 
        
    }

    [Test]
    public void Checkout_Called_Passed()
    {
        //Arrange
        
        //Act
        
        sut.Checkout(null);
        //Assert
        Assert.Pass();
    }
    
    [Test]
    public void Checkout_InputStringList_Passed()
    {
        //Arrange
     
        var books = new List<string>();
        //Act
        sut.Checkout(books);
        //Assert
        Assert.Pass();
        
    }
    
    [Test]
    public void Checkout_InputEmptyStringList_ReturnPriceDecimal()
    {
        //Arrange
        
        var books = new List<string>();
        //Act
        decimal price = sut.Checkout(books);
        //Assert
        Assert.That(price, Is.EqualTo(0));
    }
    
    [Test]
    public void Checkout_InputOneBook_Return8()
    {
        //Arrange
        var expected = 8;
        var books = new List<string> {"Book1"};
        //Act
        decimal price = sut.Checkout(books);
        
        //Assert
        Assert.That(price, Is.EqualTo(expected));
    }
}


