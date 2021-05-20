// -----------------------------------------------------------------------
// <copyright file="Paging7Tests.cs" company="econ-tec GmbH">
//     Copyright (c) econ-tec GmbH. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------
namespace Paging7Test
{
    using NUnit.Framework;
    using Paging7;

    public class Paging7Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Ctor_NewInstanceNoError()
        {
            var paging = new Paging();
        }

        [TestCase(0, "")]
        [TestCase(1, "1")]
        [TestCase(2, "1 2")]
        [TestCase(2, "1 2 3")]
        public void GetPages_WithInputParameter_ReturnsExpected(int maxPages, string expected)
        {
            var target = new Paging();
            
            var actual = target.GetPages(maxPages);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
