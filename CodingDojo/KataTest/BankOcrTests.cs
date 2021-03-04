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

        [Test]
        public void ScanFile_InputFileName_ReturnAccountNumbers()
        {
            var target = new BankOcr();
            var fileName = "emptyfile.txt";
            var expected = 0;

            List<AccountNumber> actual = target.ScanFile(fileName);

            Assert.That(actual.Count, Is.EqualTo(expected));
        }
    }

    public class BankOcr
    {
    }
}
