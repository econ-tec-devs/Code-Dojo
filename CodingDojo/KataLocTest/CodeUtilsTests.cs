// -----------------------------------------------------------------------
// <copyright file="CodeUtilsTests.cs" company="econ-tec GmbH">
//     Copyright (c) econ-tec GmbH. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------
namespace KataLocTest
{
    using NUnit.Framework;

    public class CodeUtilsTests
    {
        private CodeUtils _target;

        [SetUp]
        public void Setup()
        {
            _target = new CodeUtils();
        }

        [Test]
        public void Loc_InputEmptyString_TestPasses()
        {
            var input = string.Empty;

            _target.Loc(input);

            Assert.Pass();
        }
    }
}
