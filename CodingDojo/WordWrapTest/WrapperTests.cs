// -----------------------------------------------------------------------
// <copyright file="WrapperTests.cs" company="econ-tec GmbH">
//     Copyright (c) econ-tec GmbH. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------
namespace WordWrapTest
{
    using NUnit.Framework;
    using WordWrap;

    public class WrapperTests
    {
        [TestCase("", 0, "")]
        [TestCase("Rouven muss wieder an das Telefon.", 0, "Rouven muss wieder an das Telefon.")]
        [TestCase("Rouven muss.", 10, "Rouven\nmuss.")]
        [TestCase("Rouven muss. Ich habe Hunger!", 12, "Rouven muss.\nIch habe Hunger!")]
        public void Wrap_Inputs_ReturnsExpected(string rawString, int columnNumber, string expected)
        {
            var actual = Wrapper.Wrap(rawString, columnNumber);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
