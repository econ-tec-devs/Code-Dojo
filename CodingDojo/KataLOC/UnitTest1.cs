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

        [TestCase(1,"Console.WriteLine")]
        [TestCase(0, "")]
        public void CountCodeLines_String_HowManyLines(int expected, string lines)
        {
            var target = new LineCounter();

            var actual = target.CountCodeLines(lines);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
