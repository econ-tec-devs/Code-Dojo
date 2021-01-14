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
        private Dictionary<string, int> plates;

        [SetUp]
        public void Setup()
        {
            plates = new Dictionary<string, int>();
        }

        [Test]
        public void CalculatePrice_InputZeroDish_ReturnPrice()
        {
            var expected = 0m;

            ActAndAssert(plates, expected);
        }

        [Test]
        public void CalculatePrice_InputOneBluePlate_Return095()
        {
            plates.Add("blue", 1);
            var expected = 0.95m;

            ActAndAssert(plates, expected);
        }
        
        [Test]
        public void CalculatePrice_InputTwoBluePlate_Return190()
        {
            plates.Add("blue", 2);
            var expected = 1.90m;

            ActAndAssert(plates, expected);
        }

        [Test]
        public void CalculatePrice_InputFiveBluePlate_Return475()
        {
            plates.Add("blue", 5);
            var expected = 4.75m;

            ActAndAssert(plates, expected);
        }

        [Test]
        public void CalculatePrice_Input1Blue0RedPlates_Return095()
        {
            plates.Add("blue", 1);
            plates.Add("red", 0);
            var expected = 0.95m;

            ActAndAssert(plates, expected);
        }

        [Test]
        public void CalculatePrice_Input1Blue1RedPlates_Return290()
        {
            plates.Add("blue", 1);
            plates.Add("red", 1);
            var expected = 2.90m;

            ActAndAssert(plates, expected);
        }

        private static void ActAndAssert(Dictionary<string, int> plates, decimal expected)
        {
            var actual = Sushi.CalculatePrice(plates);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
