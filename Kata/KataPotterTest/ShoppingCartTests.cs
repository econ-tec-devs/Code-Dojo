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
        var actual = sut.Checkout(books);
        
        //Assert
        Assert.That(actual, Is.EqualTo(0));
    }
    
    [Test]
    public void Checkout_InputOneBook_Return8()
    {
        //Arrange
        var expected = 8;
        var books = new List<string> {"Book1"};
        
        //Act
        var actual = sut.Checkout(books);
        
        //Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
    
    [Test]
    public void Checkout_InputTwoEqualBooks_Return16()
    {
        //Arrange
        var expected = 16;
        var books = new List<string> {"Book1", "Book1"};
        
        //Act
        var actual = sut.Checkout(books);
        
        //Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}


