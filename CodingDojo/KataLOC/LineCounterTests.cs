// -----------------------------------------------------------------------
// <copyright file="LineCounterTests.cs" company="econ-tec GmbH">
//     Copyright (c) econ-tec GmbH. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------
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

        [TestCase(1, "Console.WriteLine")]
        [TestCase(0, "")]
        [TestCase(0, "//Console.WriteLine")]
        [TestCase(0, "/*Console.WriteLine*/")]
        [TestCase(1, "/*Console.WriteLine*/ Kein Kommentar")]
        public void CountCodeLines_String_HowManyLines(int expected, string lines)
        {
            var target = new LineCounter();

            var actual = target.CountCodeLines(lines);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
