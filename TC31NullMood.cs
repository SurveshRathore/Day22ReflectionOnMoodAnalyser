using Day20MoodAnalyzer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzerTest
{
    public class TC31NullMood
    {
        public void GivenNullReturnException()
        {
            string expected = null;
            UC3InvalidMoodInform uc3 = new(null);

            string mood = uc3.analyseMood();

            Assert.AreEqual(expected, mood);
        }
    }
}
