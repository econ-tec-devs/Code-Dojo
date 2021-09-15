// -----------------------------------------------------------------------
// <copyright file="LocTests.cs" company="econ-tec GmbH">
//     Copyright (c) econ-tec GmbH. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------
namespace KataLOCTest
{
    using System;
    using KataLOC;
    using NUnit.Framework;

    public class LocTests
    {
        private LineCounter _target;

        [SetUp]
        public void Setup()
        {
            _target = new LineCounter();
        }

        [Test]
        public void Count_EmptyString_0()
        {
            var expected = 0;

            var actual = _target.Count(string.Empty);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Count_OneLineOfCode_1()
        {
            var expected = 1;
            var text = "line1";

            var actual = _target.Count(text);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Count_TwoLineOfCode_2()
        {
            var expected = 2;
            var text = "line1" + Environment.NewLine + "line2";

            var actual = _target.Count(text);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Count_ThreeLinesOneEmptyLine_2()
        {
            var expected = 2;
            var text = "line1" + Environment.NewLine + "line2" + Environment.NewLine + "";

            var actual = _target.Count(text);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Count_ThreeLinesOneLineComment_2()
        {
            var expected = 2;
            var text = "line1" + Environment.NewLine + "line2" + Environment.NewLine + "//line comment";

            var actual = _target.Count(text);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Count_FiveLinesWithDifferentComments_3()
        {
            var expected = 3;
            var text = "line1" + Environment.NewLine
                               + "line2" + Environment.NewLine
                               + "line3" + Environment.NewLine
                               + "//line comment" + Environment.NewLine
                               + "/*line comment*/";

            var actual = _target.Count(text);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Count_OneLineWithOneComment_1()
        {
            var expected = 1;
            var text = "line1 /*line comment*/";

            var actual = _target.Count(text);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Count_OneLineStartWithOneComment_1()
        {
            var expected = 1;
            var text = "/*line comment*/ line1";

            var actual = _target.Count(text);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Count_OneLineEndWithOneComment_1()
        {
            var expected = 1;
            var text = "line1 //comment";

            var actual = _target.Count(text);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        
        public void Count_OneLineStartWithSpaces_0()
        {
            var expected = 0;
            var text = "   //comment";

            var actual = _target.Count(text);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
