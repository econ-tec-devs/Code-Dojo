// -----------------------------------------------------------------------
// <copyright file="StringConvertTests.cs" company="econ-tec GmbH">
//     Copyright (c) econ-tec GmbH. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------
namespace KataTest
{
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

        [Test]
        public void ToDictionary_OneInput_DictionaryWithOneEntry()
        {
            var input = "a=1";
            var expected = new Dictionary<string, string>
            {
                { "a", "1" }
            };

            var actual = _target.ToDictionary(input);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
