using Team1_KataPotter;
namespace Team1_KataPotterTest;

public class BasketTests
{
    private Basket _sut;
    private List<string> _books;

    [SetUp]
    public void Setup()
    {
        _sut = new Basket();
        _books = new List<string>();
    }

    [Test]
    public void Basket_Call_Pass()
    {
        _sut = new Basket();
        Assert.Pass();
    }
    
    [Test]
    public void Checkout_InputEmptyStringList_Zero()
    {
        //Arrange
        var expected = 0.00m;
        
        //Act
        var actual = _sut.Checkout(_books);

        //Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
    
    [Test]
    public void Checkout_InputOneBook_Eight()
    {
        //Arrange
        _books.Add("first book");
        var expected = 8.00m;
        
        //Act
        var actual = _sut.Checkout(_books);

        //Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Checkout_InputTwoBook_FivePercentDiscount()
    {
        //Arrange
        _books.Add("first book");
        _books.Add("second book");

        var expected = 15.20m;

        //Act
        var actual = _sut.Checkout(_books);

        //Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Checkout_InputThreeBook_TenPercentDiscount()
    {
        //Arrange
        _books.Add("first book");
        _books.Add("second book");
        _books.Add("third book");

        var expected = 21.60m;

        //Act
        var actual = _sut.Checkout(_books);

        //Assert
        Assert.That(actual, Is.EqualTo(expected));
    } 
    [Test]
    public void Checkout_InputFourBook_20PercentDiscount()
    {
        //Arrange
        _books.Add("first book");
        _books.Add("second book");
        _books.Add("third book");
        _books.Add("Fourth book");

        var expected = 25.60m;

        //Act
        var actual = _sut.Checkout(_books);

        //Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
    
    [Test]
    public void Checkout_InputFiveBook_25PercentDiscount()
    {
        //Arrange
        _books.Add("first book");
        _books.Add("second book");
        _books.Add("third book");
        _books.Add("Fourth book");

        var expected = 30m;

        //Act
        var actual = _sut.Checkout(_books);

        //Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}