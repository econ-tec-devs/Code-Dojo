using System;
using System.IO;
using NUnit.Framework;
using NUnit.Framework.Constraints;
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
        public void GoldenMaster()
        {
            var oldOut = Console.Out;
            var path = @"..\..\..\GoldenMaster.txt";
            using (var sw = new StreamWriter(new FileStream(path, FileMode.Create)))
            {
                Console.SetOut(sw);
                GameRunner.Main2(new string[0]);
                Console.SetOut(oldOut);
            }

            Assert.That(true, Is.True);
        }

        [Test]
        public void MethodeToTest_Scenario_Expected()
        {
            Assert.That(true, Is.False);
        }
    }
}
