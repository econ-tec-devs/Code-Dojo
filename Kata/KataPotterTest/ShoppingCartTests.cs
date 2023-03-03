using KataPotter;

namespace KataPotterTest;

public class ShoppingCartTests
{
    private ShoppingCart _sut;

    [SetUp]
    public void SetUp()
    {
        _sut = new ShoppingCart();
    }

    [Test]
    public void Checkout_Called_Passed()
    {
        //Act
        _sut.Checkout(null);

        //Assert
        Assert.Pass();
    }

    [Test]
    public void Checkout_InputBooks_Passed()
    {
        //Arrange
        var books = new List<string>();

        //Act
        _sut.Checkout(books);

        //Assert
        Assert.Pass();
    }

    [Test]
    public void Checkout_InputBooks_Returns0()
    {
        //Arrange
        var books = new List<string>();
        var expected = 0;

        //Act
        decimal result = _sut.Checkout(books);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    } 
    
    [Test]
    public void Checkout_InputBookOne_Returns8()
    {
        //Arrange
        var books = new List<string>(){"Book1"};
        var expected = 8;

        //Act
        decimal result = _sut.Checkout(books);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}