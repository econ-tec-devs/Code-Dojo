// -----------------------------------------------------------------------
// <copyright file="PagingTests.cs" company="econ-tec GmbH">
//     Copyright (c) econ-tec GmbH. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

using System.Collections.Generic;
using Paging7;

namespace Paging7Test
{
    using NUnit.Framework;

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

            string actual = _target.ShowPaging(1);

            Assert.That(actual, Is.EqualTo(expected));
        }
        
        [Test]
        public void ShowPaging_TwoPage_OnePageOfTwo()
        {
            var expected = "(1) 2";
            int maxPage = 2;

            string actual = _target.ShowPaging(1, maxPage);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
