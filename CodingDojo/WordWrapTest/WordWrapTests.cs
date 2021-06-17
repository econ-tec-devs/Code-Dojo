// -----------------------------------------------------------------------
// <copyright file="WordWrapTests.cs" company="econ-tec GmbH">
//     Copyright (c) econ-tec GmbH. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------
namespace WordWrapTest
{
    using NUnit.Framework;

    public class WordWrapTests
    {
        /// <summary>
        /// 1. two words, columnNumber zero => input = output
        /// 2. two words, columnNumber at first space => returns text with lineBreak after first word
        /// 3. two words, columnNumber at second word => returns text with lineBreak after first word
        /// 4. two words, columnNumber after second word => input = output
        /// 5. three words, columnNumber after first space => returns text with two lineBreaks
        /// </summary>
        [Test]
        public void Wrap_ColumnNumberZero_ReturnsInputAsOutput()
        {
            var text = "Word1 word2";
            var columnNumber = 0;
            var expected = "Word1 word2";

            string actual = Wrapper.Wrap(text, columnNumber);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
