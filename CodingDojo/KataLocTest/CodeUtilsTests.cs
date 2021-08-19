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

        [TestCase(null, 0)]
        [TestCase("", 0)]
        [TestCase("line1", 1)]
        [TestCase("line1\nline2", 2)]
        public void Loc_InputString_ReturnsExpected(string input, int expected)
        {
            var actual = _target.Loc(input);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
