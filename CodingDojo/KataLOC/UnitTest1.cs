// -----------------------------------------------------------------------
// <copyright file="UnitTest1.cs" company="econ-tec GmbH">
//     Copyright (c) econ-tec GmbH. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------
namespace KataLOCTest
{
    using KataLoc;
    using NUnit.Framework;

    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CountCodeLines_EmptyString_0()
        {
            var expected = 0;
            var target = new LineCounter();

            var actual = target.CountCodeLines(string.Empty);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
