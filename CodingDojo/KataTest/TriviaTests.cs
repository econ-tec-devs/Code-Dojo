using System;
using System.IO;
using NUnit.Framework;
using NUnit.Framework.Constraints;
using Trivia;

namespace KataTest
{
    public class TriviaTests
    {
        private string path;
        
        [SetUp]
        public void Setup()
        {
            path = @"..\..\..\GoldenMaster.txt";
        }

        //[Test]
        //public void GoldenMaster()
        //{
        //    var oldOut = Console.Out;
        //    using (var sw = new StreamWriter(new FileStream(path, FileMode.Create)))
        //    {
        //        Console.SetOut(sw);
        //        GameRunner.Main2(new string[0]);
        //        Console.SetOut(oldOut);
        //    }

        //    Assert.That(true, Is.True);
        //}

        [Test]
        public void GammeRunner_CreateFileWithCurrentGame_EqualToGoldenMaster()
        {
            var oldOut = Console.Out;
            var currentFile = @"..\..\..\CurrentOutput.txt";
            using (var sw = new StreamWriter(new FileStream(currentFile, FileMode.Create)))
            {
                Console.SetOut(sw);
                GameRunner.Main2(new string[0]);
                Console.SetOut(oldOut);
            }

            var actual = File.ReadAllText(currentFile);
            var expected = File.ReadAllText(path);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
