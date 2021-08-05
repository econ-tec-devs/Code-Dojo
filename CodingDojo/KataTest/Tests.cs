// -----------------------------------------------------------------------
// <copyright file="Tests.cs" company="econ-tec GmbH">
//     Copyright (c) econ-tec GmbH. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------
namespace KataTest
{
    using System;
    using System.Collections.Generic;
    using KataDictonary;
    using NUnit.Framework;

    public class Tests
    {
        private StringToDictionary _target;

        [SetUp]
        public void Setup()
        {
            _target = new StringToDictionary();
        }

        [Test]
        public void ToDictionary_NullInput_ReturnsEmptyDictionary()
        {
            string input = null;

            Assert.Throws<ArgumentNullException>(() => _target.ToDictionary(input));
        }

        [Test]
        public void ToDictionary_EmptyInput_ReturnsEmptyDictionary()
        {
            var input = string.Empty;
            var expected = new Dictionary<string, string>();

            var actual = _target.ToDictionary(input);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void ToDictionary_OneKeyValuePair_ReturnsAsDictionary()
        {
            var input = "a=1";
            var expected = new Dictionary<string, string> { { "a", "1" } };

            var actual = _target.ToDictionary(input);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void ToDictionary_AnotherKeyValuePair_ReturnsAsDictionary()
        {
            var input = "b=1";
            var expected = new Dictionary<string, string> { { "b", "1" } };

            var actual = _target.ToDictionary(input);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
