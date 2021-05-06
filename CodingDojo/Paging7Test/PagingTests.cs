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
        [Test]
        public void GetPaging_NoPages_ReturnsEmptyPaging()
        {
            var target = new Paging();
            var pages = 0;
            var currentPage = 0;
            var expected = string.Empty;

            string actual = target.GetPaging(pages, currentPage);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void GetPaging_OnePage_ReturnsPagingWithCurrentPageOne()
        {
            var target = new Paging();
            var pages = 1;
            var currentPage = 1;
            var expected = "(1)";

            string actual = target.GetPaging(pages, currentPage);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
