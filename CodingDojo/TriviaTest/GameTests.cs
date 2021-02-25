using System;
using System.IO;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TriviaTest
{
    [TestClass]
    public partial class GameTests
    {
        private Game _target;
        private StringBuilder   _output     = new StringBuilder();
        private string          _newLine    = Environment.NewLine;

        [TestInitialize]
        public void SetUp()
        {
            TextWriter textWriter = new StringWriter(_output );
            Console.SetOut(textWriter);

            _target = new Game();
        }

        [TestCleanup]
        public void CleanUp()
        {
            _output = null;
        }

        [TestMethod]
        public void createRockQuestion_Index1_ReturnsRockQuestion1()
        {
            Assert.AreEqual("Rock Question 1", _target.createRockQuestion(1));
        }

        [TestMethod]
        public void createRockQuestion_Index99_ReturnsRockQuestion99()
        {
            Assert.AreEqual("Rock Question 99", _target.createRockQuestion(99));
        }
        
        #region Helper Methods

        private void AddHansWurstsWithNumber(int numberOfPlayer)
        {
            for (var player = 1; player <= numberOfPlayer; player++)
            {
                _target.add(String.Format("Hans Wurst {0}", player));
            }
        }

        #endregion
     }
}
    