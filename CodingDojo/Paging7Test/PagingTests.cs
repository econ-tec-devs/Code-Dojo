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
        [TestCase(0, 0, "")]
        [TestCase(1, 1, "(1)")]
        [TestCase(2, 1, "(1) 2")]
        [TestCase(3, 1, "(1) 2 3")]
        public void GetPaging_InputParameter_ReturnsExpected(int pages, int currentPage, string expected)
        {
            var target = new Paging();

            var actual = target.GetPaging(pages, currentPage);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
