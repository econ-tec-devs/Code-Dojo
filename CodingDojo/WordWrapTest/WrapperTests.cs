// -----------------------------------------------------------------------
// <copyright file="WrapperTests.cs" company="econ-tec GmbH">
//     Copyright (c) econ-tec GmbH. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

using NUnit.Framework;
using WordWrap;

namespace WordWrapTest
{
    public class WrapperTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Wrap_EmptyArguments_ReturnsEmptyString()
        {
            var rawString = string.Empty;
            var columnNumber = 0;
            var expected = string.Empty;

            string actual = Wrapper.Wrap(rawString, columnNumber);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
