// -----------------------------------------------------------------------
// <copyright file="PagingTests.cs" company="econ-tec GmbH">
//     Copyright (c) econ-tec GmbH. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------
namespace Paging7Test
{
    using NUnit.Framework;
    using Paging7;

    public class PagingTests
    {
        private Paging _target;

        [SetUp]
        public void Setup()
        {
            _target = new Paging();
        }

        [Test]
        public void Ctor_NoDependency_NoError()
        {
            Assert.That(_target, Is.TypeOf<Paging>());
        }

        [Test]
        public void ShowPaging_OnePage_OneCurrentPage()
        {
            var expected = "(1)";

            var actual = _target.ShowPaging(1, 1);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void ShowPaging_TwoPages_OnePageOfTwo()
        {
            var expected = "(1) 2";
            var maxPage = 2;

            var actual = _target.ShowPaging(1, maxPage);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void ShowPaging_ThreePages_OnePageOfThree()
        {
            var expected = "(1) 2 3";
            var maxPage = 3;

            var actual = _target.ShowPaging(1, maxPage);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
