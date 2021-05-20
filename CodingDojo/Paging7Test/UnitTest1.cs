using NUnit.Framework;
using Paging7;

namespace Paging7Test
{
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
    }
}