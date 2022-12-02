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
