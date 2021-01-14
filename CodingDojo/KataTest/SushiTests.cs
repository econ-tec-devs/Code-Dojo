// -----------------------------------------------------------------------
// <copyright file="SushiTests.cs" company="econ-tec GmbH">
//     Copyright (c) econ-tec GmbH. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

using KataSushii;

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

            ActAndAssert(new List<string>(), expected);
        }

        [Test]
        public void CalculatePrice_InputOneBluePlate_Return095()
        {
            var plates = new List<string>() { "blue" };
            var expected = 0.95m;

            ActAndAssert(plates, expected);
        }
        
        [Test]
        public void CalculatePrice_InputTwoBluePlate_Return190()
        {
            var plates = new List<string> {"blue", "blue"};
            var expected = 1.90m;

            ActAndAssert(plates, expected);
        }

        private static void ActAndAssert(List<string> plates, decimal expected)
        {
            var actual = Sushi.CalculatePrice(plates);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
