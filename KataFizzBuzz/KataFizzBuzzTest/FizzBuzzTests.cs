using NUnit.Framework;

namespace KataFizzBuzzTest
{
    using System;
    using System.IO;
    using System.Text;
    using KataFizzBuzz;

    public class FizzBuzzTests
    {
        private StringBuilder _stringBulder;
        private FizzBuzz _sut;

        [SetUp]
        public void Setup()
        {
            var writer = new StringWriter();
            Console.SetOut(writer);
            _stringBulder = writer.GetStringBuilder();
            _sut = new FizzBuzz();
        }

        [TestCase(0, "1")]
        [TestCase(1, "2")]
        [TestCase(2, "Fizz")]
        [TestCase(3, "4")]
        [TestCase(4, "Buzz")]
        [TestCase(5, "Fizz")]
        [TestCase(6, "7")]
        [TestCase(7, "8")]
        [TestCase(8, "Fizz")]
        [TestCase(9, "Buzz")]
        [TestCase(10, "11")]
        [TestCase(11, "Fizz")]
        [TestCase(12, "13")]
        [TestCase(13, "14")]
        [TestCase(14, "FizzBuzz")]
        
        
        public void Print_Called_TestPass(int index, string expected)
        {
            // Act
            _sut.Print();
            
            // Assert
            Assert.That(AtIndex(index), Is.EqualTo(expected));
        }

        private string AtIndex(int index)
        {
            return _stringBulder.ToString().Split(Environment.NewLine)[index];
        }
    }
}
