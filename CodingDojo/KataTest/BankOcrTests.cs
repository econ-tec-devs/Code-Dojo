// -----------------------------------------------------------------------
// <copyright file="BankOcrTests.cs" company="econ-tec GmbH">
//     Copyright (c) econ-tec GmbH. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

using System.Collections.Generic;
using KataBankOcr;

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
        public void Scan_EmptyFile_ReturnsEmptyListOfAccountNumbers()
        {
            var filename = "accountNumbers.txt";
            var expected = new List<AccountNumber>();

            var actual = _target.Scan(filename);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
