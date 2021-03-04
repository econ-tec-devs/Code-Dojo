// -----------------------------------------------------------------------
// <copyright file="BankOcrTests.cs" company="econ-tec GmbH">
//     Copyright (c) econ-tec GmbH. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

using System.Collections.Generic;
using Kata;
using NSubstitute;

namespace KataTest
{
    using NUnit.Framework;

    public class BankOcrTests
    {
        private BankOcr _target;

        [SetUp]
        public void Setup()
        {
            _target = new BankOcr();
        }

        [Test]
        public void Ctor_None_NewInstanceNoException()
        {
            Assert.That(_target, Is.TypeOf<BankOcr>());
        }

        [Test]
        public void Ctor_InjectReader_NoError()
        {
            IReader reader = Substitute.For<IReader>();

            var target = new BankOcr(reader);

            Assert.That(target, Is.TypeOf<BankOcr>());
        }

        [Test]
        public void ScanFile_InputFileName_ReturnAccountNumbers()
        {
            var fileName = "emptyfile.txt";
            var expected = 0;

            List<AccountNumber> actual = _target.ScanFile(fileName);

            Assert.That(actual.Count, Is.EqualTo(expected));
        }
    }
}
