// -----------------------------------------------------------------------
// <copyright file="PagingTests.cs" company="econ-tec GmbH">
//     Copyright (c) econ-tec GmbH. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------
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
    }
}
