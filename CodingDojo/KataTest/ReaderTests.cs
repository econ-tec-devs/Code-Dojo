using NUnit.Framework;

namespace KataTest
{
    using System;

    [TestFixture]
    public class ReaderTests
    {
        private Reader _target;

        [SetUp]
        public void SetUp()
        {
            _target = new Reader();
        }

        [Test]
        public void Read_NullArgument_ThrowsArgumentNullException()
        {
            string filename = null;

            Assert.Throws<ArgumentNullException>(() => _target.Read(filename));
        }
    }
}
