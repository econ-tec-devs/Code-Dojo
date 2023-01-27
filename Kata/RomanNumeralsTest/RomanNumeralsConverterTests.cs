namespace RomanNumeralsTest;

public class RomanNumeralsConverterTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Ctor_Called_Passes()
    {
        new RomanNumeralsConverter();
        
        Assert.Pass();
    }
}
