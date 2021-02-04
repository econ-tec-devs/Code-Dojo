using System;
using System.IO;
using NUnit.Framework;
using Trivia;

namespace KataTest
{
    public class TriviaTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void MethodeToTest_Scenario_Expected()
        {
            using (var sw = new StreamWriter(new FileStream("C:\\Users\\Public\\Documents\\GoldenMaster.txt", FileMode.Create)))
            {
                Console.SetOut(sw);
                GameRunner.Main(1337);
                Assert.That(true, Is.False);
            }
        }
    }
}
