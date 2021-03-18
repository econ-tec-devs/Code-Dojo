// -----------------------------------------------------------------------
// <copyright file="ReaderTests.cs" company="econ-tec GmbH">
//     Copyright (c) econ-tec GmbH. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------
namespace KataTest
{
    using Kata;
    using NUnit.Framework;

    public class ReaderTests
    {
        [Test]
        public void Ctor_None_NewInstanceNoException()
        {
            IReader target = new Reader();

            Assert.That(target, Is.TypeOf<IReader>());
        }
    }
}
