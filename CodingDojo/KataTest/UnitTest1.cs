// -----------------------------------------------------------------------
// <copyright file="UnitTest1.cs" company="econ-tec GmbH">
//     Copyright (c) econ-tec GmbH. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------
namespace KataTest
{
    using System.Collections.Generic;
    using NUnit.Framework;

    public class PotterTests
    {
        private Potter target;

        [SetUp]
        public void Setup()
        {
            this.target = new Potter();
        }

        [Test]
        public void Calculate_EmptyListWithCountOfSameBooks_Return0()
        {
            var countOfSameBooks = new List<int>();
            var expected = 0m;

            var actual = this.target.Calculate(countOfSameBooks);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Calculate_ListWithOneSameBook_Return8()
        {
            var countOfSameBooks = new List<int>() { 1 };
            var expected = 8m;

            var actual = this.target.Calculate(countOfSameBooks);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Calculate_ListWithTwoSameBook_Return16()
        {
            var countOfSameBooks = new List<int>() { 2 };
            var expected = 16m;

            var actual = this.target.Calculate(countOfSameBooks);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
