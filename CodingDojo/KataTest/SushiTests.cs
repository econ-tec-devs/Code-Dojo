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
        public void GetPrice_InputPlates_Return0()
        {
            var expected = 0m;

            var actual = Sushi.GetPrice(null);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void GetPrice_InputEmptyPlate_Return0()
        {
            var plates = new List<string> { };
            var expected = 0;

            var actual = Sushi.GetPrice(plates);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void GetPrice_InputOneBluePlate_Return095()
        {
            var plates = new List<string> { "blue" };
            var expected = 0.95m;

            var actual = Sushi.GetPrice(plates);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void GetPrice_InputTwoBluePlate_Return190()
        {
            var plates = new List<string> { "blue", "blue" };
            var expected = 0.95m *2;

            var actual = Sushi.GetPrice(plates);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
