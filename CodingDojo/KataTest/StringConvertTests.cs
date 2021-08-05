// -----------------------------------------------------------------------
// <copyright file="StringConvertTests.cs" company="econ-tec GmbH">
//     Copyright (c) econ-tec GmbH. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------
namespace KataTest
{
    using System;
    using System.Collections.Generic;
    using Kata;
    using NUnit.Framework;

    public class StringConvertTests
    {
        private readonly StringConvert _target = new StringConvert();

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ToDictionary_EmptyInput_EmptyDictionary()
        {
            var input = string.Empty;
            var expected = new Dictionary<string, string>();

            var actual = _target.ToDictionary(input);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCase("a=1", "a", "1")]
        [TestCase("a=2", "a", "2")]
        [TestCase("a=5", "a", "5")]
        [TestCase("b=5", "b", "5")]
        [TestCase("a=", "a", "")]
        public void ToDictionary_OneInput_DictionaryWithOneEntry(string input, string expectedKey, string expectedValue)
        {
            var expected = new Dictionary<string, string>
            {
                { expectedKey, expectedValue }
            };

            var actual = _target.ToDictionary(input);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCase("=1")]
        [TestCase("=2")]
        public void ToDictionary_InvalidInput_ThrowsArgumentException(string input)
        {
            Assert.Throws<ArgumentException>(() => _target.ToDictionary(input));
        }

        [Test]
        public void ToDictionary_TwoInputs_DictionaryWithTwoEntries()
        {
            var input = "a=1;b=2";
            var expected = new Dictionary<string, string>
            {
                { "a", "1" }, { "b", "2" }
            };

            var actual = _target.ToDictionary(input);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
