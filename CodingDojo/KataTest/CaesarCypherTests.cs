// -----------------------------------------------------------------------
// <copyright file="CaesarCypherTests.cs" company="econ-tec GmbH">
//     Copyright (c) econ-tec GmbH. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------
namespace KataTest
{
    using NUnit.Framework;

    public class CaesarCypherTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Encode_InputString_ReturnsString()
        {
            // Arrange
            var input = string.Empty;
            var caesarCypher = new CaesarCypher();

            // Act
            string actual = caesarCypher.Encode(input);

            // Assert
            Assert.That(actual, Is.TypeOf<string>());
        }
    }
}
