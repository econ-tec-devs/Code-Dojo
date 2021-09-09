using System;
using NUnit.Framework;

namespace TestProject1
{
    public class KataLocTests2
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GetLinesOfCode_InputEmptystring_Return0()
        {
            LOC loc = new LOC();
            string text=String.Empty;
            int actual = loc.GetLinesOfCode(text);
            int expected = 0;

            Assert.That(actual,Is.EqualTo(expected));
        }
        
        [Test]
        public void GetLinesOfCode_InputOneLine_Return1()
        {
            LOC loc = new LOC();
            string text="line1";
            int actual = loc.GetLinesOfCode(text);
            int expected = 1;

            Assert.That(actual,Is.EqualTo(expected));
        }
        
        [Test]
        public void GetLinesOfCode_InputTwoLineOfCode_Return2()
        {
            LOC loc = new LOC();
            string text="line1\r\nline2";
            int actual = loc.GetLinesOfCode(text);
            int expected = 2;

            Assert.That(actual,Is.EqualTo(expected));
        }

        [Test]
        public void GetLinesOfCode_InputTwoLineOfCodeWithComment_Return2()
        {
            LOC loc = new LOC();
            string text="line1\r\nline2\r\n//comment";
            int actual = loc.GetLinesOfCode(text);
            int expected = 2;

            Assert.That(actual,Is.EqualTo(expected));
        }
    }
}