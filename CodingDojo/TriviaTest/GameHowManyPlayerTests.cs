using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TriviaTest
{
    public partial class GameTests
    {
        [TestMethod]
        public void howManyPlayer_NewGame_Return0()
        {
            Assert.AreEqual(0, _target.howManyPlayers());
        }

        [TestMethod]
        public void howManyPlayer_AddOnePlayer_Return1()
        {
            _target.add("Hans Wurst 1");
            
            Assert.AreEqual(1, _target.howManyPlayers());
        }

        [TestMethod]
        public void howManyPlayer_AddTwoPlayerWithSameName_Return2()
        {
            _target.add("Hans Wurst");
            _target.add("Hans Wurst");

            Assert.AreEqual(2, _target.howManyPlayers());
        }
        
        [TestMethod]
        public void howManyPlayer_AddFivePlayer_Return5()
        {
            var numberOfPlayer = 5;
            AddHansWurstsWithNumber(numberOfPlayer);

            Assert.AreEqual(numberOfPlayer, _target.howManyPlayers());
        }
     }
}
