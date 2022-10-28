using NUnit.Framework;

namespace KataTest
{
    using Microsoft.VisualStudio.TestPlatform.TestHost;

    public class ProgramTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CalcArea_Called_TestPass()
        {
            // Arrange
            var sut = new Program();
            
            // Act
            sut.CalcArea();
            
            // Assert
            Assert.Pass();
        }
    }
}
