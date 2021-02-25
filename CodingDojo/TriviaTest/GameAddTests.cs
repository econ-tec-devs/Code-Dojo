using System;
using System.IO;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TriviaTest
{
    public partial class GameTests
    {
        [TestMethod]
        public void add_AddTwoPlayerWithSameName_WriteLineReturnsExpectedText()
        {
            _output.Clear();
            var expected =  "Hans Wurst was added" + Environment.NewLine + 
                            "They are player number 1" + Environment.NewLine + 
                            "Hans Wurst was added" + Environment.NewLine + 
                            "They are player number 2" + Environment.NewLine;

            _target.add("Hans Wurst");
            _target.add("Hans Wurst");

            Assert.AreEqual(expected, _output.ToString());
        }

        [TestMethod]
        public void add_AddOnePlayer_WriteLineReturnsExpectedText()
        {
            _output.Clear();
            var expected = "Hans Wurst 1 was added" + Environment.NewLine + "They are player number 1" + Environment.NewLine;

            _target.add("Hans Wurst 1");

            Assert.AreEqual(expected, _output.ToString());
        }

        [TestMethod]
        public void add_AddFivePlayer_WriteLineReturnsExpectedText()
        {
            _output.Clear();
            var expected = "";
            var numberOfPlayer = 5;
            for (var player = 1; player <= numberOfPlayer; player++)
            {
                expected += String.Format("Hans Wurst {0} was added{1}They are player number {0}{1}", player, Environment.NewLine);
                _target.add(String.Format("Hans Wurst {0}", player));
            }

            Assert.AreEqual(expected, _output.ToString());
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void add_AddSixPlayer_ThrowException()
        {
            AddHansWurstsWithNumber(6);
        }
     }
}
