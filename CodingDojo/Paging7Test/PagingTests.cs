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
        [TestCase(0,0,"")]
        [TestCase(1,1,"(1)")]
        public void GetPaging_TwoPages_ReturnsPagingWithCurrentPageOne(int pages, int currentPage, string expected)
        {
            var target = new Paging();

            string actual = target.GetPaging(pages, currentPage);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
