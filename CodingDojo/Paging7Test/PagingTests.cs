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
        [TestCase(3, 1, "(1) 2 3")]
        [TestCase(4, 1, "(1) 2 3 4")]
        [TestCase(7, 1, "(1) 2 3 4 5 6 7")]
        [TestCase(7, 2, "1 (2) 3 4 5 6 7")]
        [TestCase(7, 4, "1 2 3 (4) 5 6 7")]
        [TestCase(7, 7, "1 2 3 4 5 6 (7)")]
        [TestCase(3, 3, "1 2 (3)")]
        public void GetPaging_InputParameters_ReturnsExpected(int pageCount, int currentPage, string expected)
        {
            ActAndAssert(pageCount, currentPage, expected);
        }

        [TestCase(9, 5, "1 ... 4 (5) 6 ... 9")]
        [TestCase(100, 42, "1 ... 41 (42) 43 ... 100")]
        [TestCase(70, 30, "1 ... 29 (30) 31 ... 70")]
        [TestCase(150, 139, "1 ... 138 (139) 140 ... 150")]
        [TestCase(300, 250, "1 ... 249 (250) 251 ... 300")]
        public void GetPaging_PageCountOverSeven_ReturnsExpected(int pageCount, int currentPage, string expected)
        {
            ActAndAssert(pageCount, currentPage, expected);
        }

        [TestCase(9, 2, "1 (2) 3 4 5 ... 9")]
        [TestCase(9, 4, "1 2 3 (4) 5 ... 9")]
        [TestCase(9, 3, "1 2 (3) 4 5 ... 9")]
        public void GetPaging_CurrentPageInFirstPart_ReturnsExpected(int pageCount, int currentPage, string expected)
        {
            ActAndAssert(pageCount, currentPage, expected);
        }

        [TestCase(9, 8, "1 ... 5 6 7 (8) 9")]
        [TestCase(9, 7, "1 ... 5 6 (7) 8 9")]
        public void GetPaging_CurrentPageInLastPart_ReturnsExpected(int pageCount, int currentPage, string expected)
        {
            ActAndAssert(pageCount, currentPage, expected);
        }

        private void ActAndAssert(int pageCount, int currentPage, string expected)
        {
            var paging = new Paging();

            var actual = paging.GetPaging(pageCount, currentPage);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
