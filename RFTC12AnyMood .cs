using Day20MoodAnalyzer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzerTest
{
    [TestClass]
    public class RFTC12AnyMood
    {
        [TestMethod]
        public void GivenAnyReturnHappy()
        {
            string expected = "HAPPY";
            string message = "I am in Happy Mood";
            RF1msgCons rf1 = new(message);

            string mood = rf1.analyseMood();

            Assert.AreEqual(expected, mood);
        }
        
    }
}
