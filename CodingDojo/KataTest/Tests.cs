// -----------------------------------------------------------------------
// <copyright file="Tests.cs" company="econ-tec GmbH">
//     Copyright (c) econ-tec GmbH. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

using System.Collections.Generic;
using KataDictonary;

namespace KataTest
{
    using System;
    using NUnit.Framework;

    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ToDictionary_NullInput_ReturnsEmptyDictionary()
        {
            var target = new StringToDictionary();
            string input = null;

            Assert.Throws<ArgumentNullException>(() => target.ToDictionary(input));
        }

        [Test]
        public void ToDictionary_EmptyInput_ReturnsEmptyDictionary()
        {
            var target = new StringToDictionary();
            var input = string.Empty;
            var expected = new Dictionary<string, string>();

            var actual = target.ToDictionary(input);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
