using NUnit.Framework;

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
            Assert.That(true, Is.False);
        }
    }
}
