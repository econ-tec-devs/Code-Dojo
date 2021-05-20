// -----------------------------------------------------------------------
// <copyright file="Paging7Tests.cs" company="econ-tec GmbH">
//     Copyright (c) econ-tec GmbH. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------
namespace Paging7Test
{
    using NUnit.Framework;
    using Paging7;

    public class Paging7Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Ctor_NewInstanceNoError()
        {
            var paging = new Paging();
        }

        [Test]
        public void GetPages_MaxPages0_ReturnsEmptyString()
        {
            var target = new Paging();
            var expected = string.Empty;

            var actual = target.GetPages(0);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void GetPages_MaxPages1_ReturnsStringWith1()
        {
            var target = new Paging();
            var expected = "1";

            var actual = target.GetPages(1);

            Assert.That(actual, Is.EqualTo(expected));
        }  
        
        [Test]
        public void GetPages_MaxPages2_ReturnsStringWith12()
        {
            var target = new Paging();
            var expected = "1 2";

            var actual = target.GetPages(2);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
