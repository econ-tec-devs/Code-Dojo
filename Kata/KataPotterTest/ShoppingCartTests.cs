using KataPotter;

namespace KataPotterTest;

public class ShoppingCartTests
{
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
    public void Checkout_InputBooks_Passed()
    {
        //Arrange
        var sut = new ShoppingCart();
        var books = new List<string>();
        //Act
        sut.Checkout(books);

        //Assert
        Assert.Pass();
    }
}