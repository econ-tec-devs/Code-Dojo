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

        [Test]
        public void CountCodeLines_StringWithOneLine_1()
        {
            var expected = 1;
            var lines = "Console.Write";
            var target = new LineCounter();

            var actual = target.CountCodeLines(lines);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
