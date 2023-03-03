using Team1_KataPotter;
namespace Team1_KataPotterTest;

public class KataPotterTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Basket_Call_Pass()
    {
        var sut = new Basket();
        
        Assert.Pass();
    }
    
    [Test]
    public void Checkout_InputEmptyStringList_Zero()
    {
        //Arrange
        var sut = new Basket();
        var books = new List<string>();
        var expected = 0.00m;
        
        //Act
        var actual = sut.Checkout(books);

        //Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
    
    [Test]
    public void Checkout_InputOneBook_Eight()
    {
        //Arrange
        var sut = new Basket();
        var books = new List<string>() { "book1" };
        var expected = 8.00m;
        
        //Act
        var actual = sut.Checkout(books);

        //Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}