// -----------------------------------------------------------------------
// <copyright file="TriviaTests.cs" company="econ-tec GmbH">
//     Copyright (c) econ-tec GmbH. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------
namespace KataTest
{
    using System;
    using System.IO;
    using System.Text;
    using NUnit.Framework;
    using Trivia;

    public class TriviaTests
    {
        private string path;

        [SetUp]
        public void Setup()
        {
            path = "GoldenMaster.txt";
        }

        //[Test]
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

        [Test]
        public void MethodeToTest_ReadFile_ReturnNotEmptyString()
        {
            var expected = string.Empty;

            var actual = File.ReadAllText(this.path);

            Assert.That(actual, Is.Not.EqualTo(expected));
        }

        [Test]
        public void MethodeToTest_CompareFileWithGameOutput_ReturnTrueIfEqual()
        {
            var expected = File.ReadAllText(this.path);

            var stringBuilder = new StringBuilder();
            Console.SetOut(new StringWriter(stringBuilder));
            GameRunner.Main(1337);
            var actual = stringBuilder.ToString();

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
