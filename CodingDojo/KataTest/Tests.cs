// -----------------------------------------------------------------------
// <copyright file="Tests.cs" company="econ-tec GmbH">
//     Copyright (c) econ-tec GmbH. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------
namespace KataTest
{
    using System;
    using NUnit.Framework;

    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ToDictionary_NullInput_ReturnsEmptyDictionary()
        {
            var target = new StringToDictionary();
            string input = null;

            Assert.Throws<ArgumentNullException>(() => target.ToDictionary(input));
        }
    }
}
