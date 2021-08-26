using System;
using KataLoc;
using NUnit.Framework;

namespace KataLocTest
{
    [TestFixture]
    public class LinesOfCodeTests
    {
        [Test]
        public void Count_StringInput_ReturnsZero()
        {
            var target = new LinesOfCode();
            var input = string.Empty;
            var expected = 0;

            var actual = target.Count(input);
            
            Assert.That(actual, Is.EqualTo(expected));
        }
        
        [Test]
        public void Count_StringInputNullOrWhiteSpace_ReturnsZero()
        {
            var target = new LinesOfCode();
            string input = null;
            var expected = 0;

            var actual = target.Count(input);
            
            Assert.That(actual, Is.EqualTo(expected));
        }
        
        [Test]
        public void Count_StringInputOneLineOfCode_ReturnsOne()
        {
            var target = new LinesOfCode();
            string input = "Console.WriteLine()";
            var expected = 1;

            var actual = target.Count(input);
            
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
