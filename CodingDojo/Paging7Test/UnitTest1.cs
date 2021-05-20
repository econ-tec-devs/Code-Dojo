using NUnit.Framework;

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
    }
}