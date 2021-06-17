// -----------------------------------------------------------------------
// <copyright file="WordWrapTests.cs" company="econ-tec GmbH">
//     Copyright (c) econ-tec GmbH. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------
namespace WordWrapTest
{
    using System;
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
        [Test]
        public void Wrap_ColumnNumberZero_ReturnsInputAsOutput()
        {
            var text = "Word1 word2";
            var columnNumber = 0;
            var expected = "Word1 word2";

            var actual = Wrapper.Wrap(text, columnNumber);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Wrap_ColumnNumber5_ReturnsExpected()
        {
            var text = "Word1 word2";
            var columnNumber = 5;
            var expected = $"Word1{Environment.NewLine}word2";

            var actual = Wrapper.Wrap(text, columnNumber);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
