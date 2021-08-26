// -----------------------------------------------------------------------
// <copyright file="UnitTest1.cs" company="econ-tec GmbH">
//     Copyright (c) econ-tec GmbH. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

using System;

namespace KataLOCTest
{
    using KataLoc;
    using NUnit.Framework;

    public class LineCouhnterTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(1,"Console.WriteLine")]
        [TestCase(0, "")]
        [TestCase(0, "//Console.WriteLine")]
        [TestCase(0, "/*Console.WriteLine*/")]
        public void CountCodeLines_String_HowManyLines(int expected, string lines)
        {
            var target = new LineCounter();

            var actual = target.CountCodeLines(lines);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
