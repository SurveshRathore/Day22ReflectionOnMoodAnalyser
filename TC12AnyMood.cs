using Day20MoodAnalyzer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzerTest
{
    [TestClass]
    public class TC12AnyMood
    {
        [TestMethod]
        public void GivenAnyReturnHappy()
        {
            string expected = "HAPPY";
            string message = "I am in Any Mood";
            UC1AnalyzeMood uc1am = new();

            string mood = uc1am.analyseMood(message);

            Assert.AreEqual(expected, mood);
        }
        
    }
}
