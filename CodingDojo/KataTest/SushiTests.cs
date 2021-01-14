// -----------------------------------------------------------------------
// <copyright file="SushiTests.cs" company="econ-tec GmbH">
//     Copyright (c) econ-tec GmbH. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------
namespace KataTest
{
    using System.Collections.Generic;
    using NUnit.Framework;

    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CalculatePrice_InputZeroDish_ReturnPrice()
        {
            var expected = 0m;

            var actual = Sushi.CalculatePrice();

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void CalculatePrice_InputOneBluePlate_Return095()
        {
            var plates = new List<string>() { "blue" };
            var expected = 0.95m;

            var actual = Sushi.CalculatePrice(plates);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
