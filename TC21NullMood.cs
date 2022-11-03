using Day20MoodAnalyzer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzerTest
{
    [TestClass]
    public class TC21NullMood
    {
        [TestMethod]
        public void GivenNullReturnHappy()
        {
            string expected = "HAPPY";
            string message = null;
            UC1AnalyzeMood uc1am = new();

            string mood = uc1am.analyseMood(message);

            Assert.AreEqual(expected, mood);
        }
    }
}
