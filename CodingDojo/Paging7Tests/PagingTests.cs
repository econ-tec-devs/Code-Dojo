// -----------------------------------------------------------------------
// <copyright file="PagingTests.cs" company="econ-tec GmbH">
//     Copyright (c) econ-tec GmbH. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------
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
            Paging target = new Paging();

            Assert.That(target, Is.TypeOf<Paging>());
        }
    }
}
