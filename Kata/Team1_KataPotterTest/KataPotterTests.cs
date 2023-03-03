using Team1_KataPotter;
namespace Team1_KataPotterTest;

public class KataPotterTests
{
    private Basket _sut = new Basket();
    private List<string> _books = new List<string>();

    [SetUp]
    public void Setup()
    {
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
}