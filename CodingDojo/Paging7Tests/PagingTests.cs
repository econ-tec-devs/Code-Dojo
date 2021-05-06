// -----------------------------------------------------------------------
// <copyright file="PagingTests.cs" company="econ-tec GmbH">
//     Copyright (c) econ-tec GmbH. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

using Paging7;

namespace Paging7Test
{
    using NUnit.Framework;

    public class PagingTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Ctor_NoDependency_NoError()
        {
            var target = new Paging();

            Assert.That(target, Is.TypeOf<Paging>());
        }

        [Test]
        public void ShowPaging_OnePage_OneCurrentPage()
        {
            var target = new Paging();
            var expected = "(1)";

            string actual = target.ShowPaging(1);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
