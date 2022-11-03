using Day20MoodAnalyzer;
namespace MoodAnalyzerTest
{
    [TestClass]
    public class RFTC11SadMood
    {
        [TestMethod]
        public void TestMethodSadMood()
        {
            string expected = "SAD";
            string message = "I am in Sad Mood";
            RF1msgCons rf1 = new(message);

            string mood = rf1.analyseMood();

            Assert.AreEqual(expected, mood);
        }
    }
}