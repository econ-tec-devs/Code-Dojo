// -----------------------------------------------------------------------
// <copyright file="WordWrapTests.cs" company="econ-tec GmbH">
//     Copyright (c) econ-tec GmbH. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------
namespace WordWrapTest
{
    using NUnit.Framework;
    using WordWrap;

    public class WordWrapTests
    {
        /// <summary>
        /// 1. two words, columnNumber zero => input = output
        /// 2. two words, columnNumber at first space => returns text with lineBreak after first word
        /// 3. two words, columnNumber at second word => returns text with lineBreak after first word
        /// 4. two words, columnNumber after second word => input = output
        /// 5. three words, columnNumber after first word => returns text with two lineBreaks
        /// </summary>
        [TestCase("Word1 word2", 0, "Word1 word2")]
        [TestCase("Word1 word2", 5, "Word1\r\nword2")]
        [TestCase("Word1 word2", 8, "Word1\r\nword2")]
        public void Wrap_ColumnNumberZero_ReturnsInputAsOutput(string text, int columnNumber, string expected)
        {
            var actual = Wrapper.Wrap(text, columnNumber);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
