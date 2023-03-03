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
}