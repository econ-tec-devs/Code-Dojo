using Kniffel;
namespace KniffelTest;

public class KniffelGameTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Dice_Called_Passed()
    {
        // Arrange
        var sut = new KniffelGame();

        // Act
        sut.Dice();

        // Assert
        Assert.Pass();
    }
    
    [Test]
    public void Dice_Called_ReturnFiveNumbers()
    {
        // Arrange
        var sut = new KniffelGame();
        int[] expected = new[] { 1, 1, 1, 1, 1};
        
        // Act
        int[] actual = sut.Dice();
        
        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
    
    [Test]
    public void Dice_Called_NumbersBiggerThan0()
    {
        // Arrange
        var sut = new KniffelGame();
       
        // Act
        int[] actual = sut.Dice();
        
        // Assert
        foreach (var i in actual)
        {
           Assert.That(i, Is.GreaterThan(0)); 
           
        }
    }
    
    [Test]
    public void Dice_Called_NumbersLessThan7()
    {
        // Arrange
        var sut = new KniffelGame();
        
        // Act
        int[] actual = sut.Dice();
        
        // Assert
        foreach (var i in actual)
        {
           Assert.That(i, Is.LessThan(7)); 
           
        }
    }
    
    [Test]
    public void Dice_CalledTwice_ReturnsDifferentNumbers()
    {
        // Arrange
        var sut = new KniffelGame();
        
        // Act
        int[] actual1 = sut.Dice();
        int[] actual2 = sut.Dice();
        
        // Assert
      
        Assert.That(actual1, Is.Not.EqualTo(actual2));
    }
}

