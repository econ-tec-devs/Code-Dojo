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

            ActAndAssert(input, expected);
        }

        [Test]
        public void ToDictionary_OneKeyValuePair_ReturnsAsDictionary()
        {
            var input = "a=1";
            var expected = new Dictionary<string, string> { { "a", "1" } };

            ActAndAssert(input, expected);
        }

        [Test]
        public void ToDictionary_AnotherKeyValuePair_ReturnsAsDictionary()
        {
            var input = "b=1";
            var expected = new Dictionary<string, string> { { "b", "1" } };

            ActAndAssert(input, expected);
        }

        [Test]
        public void ToDictionary_ReversedKeyValuePair_ReturnsAsDictionary()
        {
            var input = "1=a";
            var expected = new Dictionary<string, string> { { "1", "a" } };

            ActAndAssert(input, expected);
        }

        [Test]
        public void ToDictionary_KeyValuePair_ReturnsAsDictionary()
        {
            var input = "aaa=111";
            var expected = new Dictionary<string, string> { { "aaa", "111" } };

            ActAndAssert(input, expected);
        }

        [Test]
        public void ToDictionary_TwoKeyValuePairs_ReturnsAsDictionary()
        {
            var input = "a=1;b=2";
            var expected = new Dictionary<string, string> { { "a", "1" }, { "b", "2" } };

            ActAndAssert(input, expected);
        }

        [Test]
        public void ToDictionary_ThreeKeyValuePairs_ReturnsAsDictionary()
        {
            var input = "a=1;b=2;c=3";
            var expected = new Dictionary<string, string> { { "a", "1" }, { "b", "2" }, {"c", "3"} };

            ActAndAssert(input, expected);
        }

        [Test]
        public void ToDictionary_DoubleKeyValuePairs_ReturnsAsDictionary()
        {
            var input = "a=1;a=2";
            var expected = new Dictionary<string, string> { { "a", "2" } };

            ActAndAssert(input, expected);
        }


        private void ActAndAssert(string input, Dictionary<string, string> expected)
        {
            var actual = _target.ToDictionary(input);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
