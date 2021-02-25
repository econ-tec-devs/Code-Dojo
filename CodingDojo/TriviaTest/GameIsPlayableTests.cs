using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TriviaTest
{
    public partial class GameTests
    {
        [TestMethod]
        public void isPlayable_NoPlayers_ReturnsFalse()
        {
            bool actual = _target.isPlayable();

            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void isPlayable_OnePlayer_ReturnsFalse()
        {
            _target.add("Hans Wurst");

            var actual = _target.isPlayable();

            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void isPlayable_TwoPlayer_ReturnsTrue()
        {
            AddHansWurstsWithNumber(2);

            Assert.IsTrue(_target.isPlayable());
        }

    }
}
