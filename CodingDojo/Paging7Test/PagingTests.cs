// -----------------------------------------------------------------------
// <copyright file="PagingTests.cs" company="econ-tec GmbH">
//     Copyright (c) econ-tec GmbH. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

using Paging7;

namespace Paging7Test
{
    using NUnit.Framework;

    [TestFixture]
    public class PagingTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GetPaging_NoPages_ReturnsEmptyString()
        {
            var paging = new Paging();
            var pageCount = 0;
            var currentPage = 0;
            var expected = string.Empty;

            string actual = paging.GetPaging(pageCount, currentPage);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void GetPaging_OnePage_ReturnsPaging()
        {
            var paging = new Paging();
            var pageCount = 1;
            var currentPage = 1;
            var expected = "(1)";

            string actual = paging.GetPaging(pageCount, currentPage);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void GetPaging_TwoPages_ReturnsPaging()
        {
            var paging = new Paging();
            var pageCount = 2;
            var currentPage = 1;
            var expected = "(1) 2";

            string actual = paging.GetPaging(pageCount, currentPage);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
