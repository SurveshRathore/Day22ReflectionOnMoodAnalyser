using Day20MoodAnalyzer;
namespace MoodAnalyzerTest
{
    [TestClass]
    public class TC11SadMood
    {
        [TestMethod]
        public void TestMethodSadMood()
        {
            string expected = "SAD";
            string message = "I am in Sad Mood";
            UC1AnalyzeMood uc1am = new();

            string mood = uc1am.analyseMood(message);

            Assert.AreEqual(expected, mood);
        }
    }
}