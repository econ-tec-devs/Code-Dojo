using NUnit.Framework;

namespace KataFizzBuzzTest
{
    using System;
    using System.IO;
    using KataFizzBuzz;

    public class FizzBuzzTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Print_Called_TestPassed()
        {
            // Arrange
            var sut = new FizzBuzz();
            
            // Act
            sut.Print();
            
            // Assert
            Assert.Pass();
        }

        [Test]
        public void Print_Called_Returns1()
        {
            // Arrange 
            var writer = new StringWriter();
            Console.SetOut(writer);
            var stringBulder = writer.GetStringBuilder();
            var expected = "1";
            var sut = new FizzBuzz();
            
            // Act
            sut.Print();
            
            // Assert
            Assert.That(stringBulder.ToString(), Is.EqualTo(expected));
        }
    
        [Test]
        public void Print_Called_Returns2()
        {
            // Arrange 
            var writer = new StringWriter();
            Console.SetOut(writer);
            var stringBulder = writer.GetStringBuilder();
            var expected = "1\r\n2";
            var sut = new FizzBuzz();
            
            // Act
            sut.Print();
            
            // Assert
            Assert.That(stringBulder.ToString(), Is.EqualTo(expected));
        } [Test]
        public void Print_Called_ReturnsFizz()
        {
            // Arrange 
            var writer = new StringWriter();
            Console.SetOut(writer);
            var stringBulder = writer.GetStringBuilder();
            var expected = "1\r\n2\r\nFizz";
            var sut = new FizzBuzz();
            
            // Act
            sut.Print();
            
            // Assert
            Assert.That(stringBulder.ToString(), Is.EqualTo(expected));
        }
    }
}
