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
            List<string> plates = null;
            var expected = 0m;

            ActAndAssert(plates, expected);
        }

        [Test]
        public void GetPrice_InputEmptyPlate_Return0()
        {
            var plates = new List<string> { };
            var expected = 0;

            ActAndAssert(plates, expected);
        }

        [Test]
        public void GetPrice_InputOneBluePlate_Return095()
        {
            var plates = new List<string> { "blue" };
            var expected = 0.95m;

            ActAndAssert(plates, expected);
        }

        [Test]
        public void GetPrice_InputTwoBluePlate_Return190()
        {
            var plates = new List<string> { "blue", "blue" };
            var expected = 0.95m * 2;

            ActAndAssert(plates, expected);
        }

        [Test]
        public void GetPrice_InputThreeBluePlate_Return285()
        {
            var plates = new List<string> { "blue", "blue", "blue" };
            var expected = 0.95m * 3;

            ActAndAssert(plates, expected);
        }

        [Test]
        public void GetPrice_InputFourBluePlate_Return380()
        {
            var plates = new List<string> { "blue", "blue", "blue", "blue" };
            var expected = 0.95m * 4;

            ActAndAssert(plates, expected);
        }

        [Test]
        public void GetPrice_InputFiveBluePlate_Return475()
        {
            var plates = new List<string> { "blue", "blue", "blue", "blue", "blue" };
            var expected = 0.95m * 5;

            ActAndAssert(plates, expected);
        }

        [Test]
        public void GetPrice_InputThreeRedPlate_Return585()
        {
            var plates = new List<string> { "red", "red", "red" };
            var expected = 1.95m * 3;

            ActAndAssert(plates, expected);
        }

        [Test]
        public void GetPrice_InputThreeYellowPlate_Return885()
        {
            var plates = new List<string> { "Yellow", "Yellow", "Yellow" };
            var expected = 2.95m * 3;

            ActAndAssert(plates, expected);
        }

        private static void ActAndAssert(List<string> plates, decimal expected)
        {
            var actual = Sushi.GetPrice(plates);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
