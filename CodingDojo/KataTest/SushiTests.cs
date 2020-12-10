// -----------------------------------------------------------------------
// <copyright file="SushiTests.cs" company="econ-tec GmbH">
//     Copyright (c) econ-tec GmbH. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------
namespace KataTest
{
    using System.Collections.Generic;
    using NUnit.Framework;

    public class SushiTests
    {
        [Test]
        public void GetPrice_InputPlates_ReturnPrice()
        {
            var expected = 0;

            var actual = Sushi.GetPrice(null);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void GetPrice_InputOneBluePlate_ReturnOnePrice()
        {
            var plates = new List<string> { };
            var expected = 0;

            var actual = Sushi.GetPrice(plates);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
