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
            GameRunner.Main(1337);
            Assert.That(true, Is.False);
        }
    }
}
