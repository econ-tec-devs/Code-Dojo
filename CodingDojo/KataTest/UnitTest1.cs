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
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Calculate_EmptyListWithCountOfSameBooks_Return0()
        {
            var target = new Potter();
            var countOfSameBooks = new List<int>();
            var expected = 0m;

            var actual = target.Calculate(countOfSameBooks);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }

    public class Potter
    {
        public decimal Calculate(List<int> countOfSameBooks)
        {
            return 0;
        }
    }
}
