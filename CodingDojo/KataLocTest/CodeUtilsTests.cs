// -----------------------------------------------------------------------
// <copyright file="CodeUtilsTests.cs" company="econ-tec GmbH">
//     Copyright (c) econ-tec GmbH. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------
namespace KataLocTest
{
    using KataLoc;
    using NUnit.Framework;

    public class CodeUtilsTests
    {
        private CodeUtils _target;

        [SetUp]
        public void Setup()
        {
            _target = new CodeUtils();
        }

        [Test]
        public void Loc_InputEmptyString_TestPasses()
        {
            var input = string.Empty;

            _target.Loc(input);

            Assert.Pass();
        }

        [Test]
        public void Loc_InputEmptyString_ReturnsZero()
        {
            var input = string.Empty;
            var expected = 0;

            var actual = _target.Loc(input);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Loc_InputNull_ReturnsZero()
        {
            string input = null;
            var expected = 0;

            var actual = _target.Loc(input);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Loc_InputOneLine_ReturnsOne()
        {
            var input = "line";
            var expected = 1;

            var actual = _target.Loc(input);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
