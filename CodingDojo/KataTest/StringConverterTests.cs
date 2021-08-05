using System;
using System.Collections.Generic;

namespace KataTest
{
    using NUnit.Framework;

    public class StringConverterTests
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
    }
}
