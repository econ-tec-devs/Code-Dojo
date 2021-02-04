using System;
using System.IO;
using NUnit.Framework;
using NUnit.Framework.Constraints;

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

            var path = @"..\GoldenMaster.txt";
            var fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);

            var sw = new StreamWriter(fs);
            Console.SetOut(sw);
            Console.WriteLine("Test");
            //Trivia.GameRunner.Main2(new string[0]);
            Console.SetOut(oldOut);
            sw.Close();
            fs.Close();

            Assert.That(true, Is.True);
        }

        [Test]
        public void MethodeToTest_Scenario_Expected()
        {
            Assert.That(true, Is.False);
        }
    }
}
