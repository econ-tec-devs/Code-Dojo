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
        Basket sut = new Basket();
        
        Assert.Pass();
    }
    
    [Test]
    public void Basket_InputEmptyStringList_Passed()
    {
        //Arrange
        Basket sut = new Basket();
        List<string> books = new List<string>();
        decimal expected = 0;
        
        //Act
        decimal actual = sut.Checkout(books);

        //Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}