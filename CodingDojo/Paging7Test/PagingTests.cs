// -----------------------------------------------------------------------
// <copyright file="PagingTests.cs" company="econ-tec GmbH">
//     Copyright (c) econ-tec GmbH. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------
namespace Paging7Test
{
    using NUnit.Framework;
    using Paging7;

    [TestFixture]
    public class PagingTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(0, 0, "")]
        [TestCase(1, 1, "(1)")]
        [TestCase(2, 1, "(1) 2")]
        public void GetPaging_InputParameters_ReturnsExpected(int pageCount, int currentPage, string expected)
        {
            var paging = new Paging();

            var actual = paging.GetPaging(pageCount, currentPage);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
