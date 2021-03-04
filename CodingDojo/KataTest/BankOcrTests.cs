// -----------------------------------------------------------------------
// <copyright file="BankOcrTests.cs" company="econ-tec GmbH">
//     Copyright (c) econ-tec GmbH. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------
namespace KataTest
{
    using NUnit.Framework;

    public class BankOcrTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Ctor_None_NewInstanceNoException()
        {
            var target = new BankOcr();

            Assert.That(target, Is.TypeOf<BankOcr>());
        }
    }

    public class BankOcr
    {
    }
}
