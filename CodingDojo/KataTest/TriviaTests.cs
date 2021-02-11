// -----------------------------------------------------------------------
// <copyright file="TriviaTests.cs" company="econ-tec GmbH">
//     Copyright (c) econ-tec GmbH. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------
namespace KataTest
{
    using System;
    using System.IO;
    using NUnit.Framework;
    using Trivia;

    public class TriviaTests
    {
        private string path;

        [SetUp]
        public void Setup()
        {
            path = "C:\\Users\\Public\\Documents\\GoldenMaster.txt";
        }

        [Test]
        public void MethodeToTest_CreateFileFromOut_ReturnIfFileExist()
        {
            var expected = true;

            using (var sw = new StreamWriter(new FileStream(this.path, FileMode.Create)))
            {
                Console.SetOut(sw);
                GameRunner.Main(1337);
            }
            var actual = File.Exists(path);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
