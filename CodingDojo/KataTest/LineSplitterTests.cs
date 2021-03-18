// -----------------------------------------------------------------------
// <copyright file="LineSplitterTests.cs" company="econ-tec GmbH">
//     Copyright (c) econ-tec GmbH. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------
namespace KataTest
{
    using Kata;
    using NUnit.Framework;

    internal class LineSplitterTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Ctor_NewInstance_ImplementsILineSplitter()
        {
            var target = new LineSplitter() as ILineSplitter;
            Assert.That(target, Is.Not.Null);
        }
    }
}
