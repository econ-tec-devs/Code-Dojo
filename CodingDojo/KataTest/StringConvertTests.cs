using System;
using System.Collections.Generic;
using Kata;

namespace KataTest
{
    using NUnit.Framework;

    public class StringConvertTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ToDictionary_EmptyInput_EmptyDictionary()
        {
            var input = string.Empty;
            var expected = new Dictionary<string, string>();
            var stringConvert = new StringConvert();

            var actual = stringConvert.ToDictionary(input);

            Assert.That(actual, Is.EqualTo(expected));
        }
        
        [Test]
        public void ToDictionary_OneInput_DictionaryWithOneEntry()
        {
            var input = "a=1";
            var expected = new Dictionary<string, string>
            {
                {"a","1"}
            };
            var stringConvert = new StringConvert();

            var actual = stringConvert.ToDictionary(input);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
