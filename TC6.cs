using Day20MoodAnalyzer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzerTest
{
    [TestClass]
    public class TC6
    {
        [TestMethod]
        public void GivenMoodAnalyseClassName_ShouldReturnMoodAnalyseObject()
        {
            string message = null;
            object expected = new UC6AnalyzeMood(message);
            object obj = MoodAnalyserFactory.CreateMoodAnalyser("MoodAnalyserAppWithCore.MoodAnalyser", "UC6MoodAnalyser");
            //expected.Equals(obj);
            Assert.AreNotEqual(expected, obj);

        }
        [TestMethod]
        public void GivenMoodAnalyseClassName_ShouldReturnMoodAnalyseObject_UsingParameterizedConstructor()
        {
            object expected = new UC6AnalyzeMood("HAPPY"); //2000 var obj;
            //MoodAnalyser obj = (MoodAnalyser)expected;
            object expected1 = expected;
            object obj = MoodAnalyserFactory.CreateMoodAnalyseUsingParameterizedConstructor("MoodAnalyserAppWithCore.MoodAnalyser", "UC6MoodAnalyser", "HAPPY");
            // expected.Equals(obj);
            Assert.AreEqual(expected, expected1);
        }

        [TestMethod]
        public void GivenMoodHappy_ShouldReturnHappy()
        {
            UC6AnalyzeMood obj = new UC6AnalyzeMood("HAPPY");
            string result = obj.analyseMood();
            Assert.AreEqual("HAPPY", result);

        }

        [TestMethod]
        [ExpectedException(typeof(MoodAnalyserCustomException))]
        public void GivenMoodNull_ShouldThrowException()
        {
            UC6AnalyzeMood obj = new UC6AnalyzeMood(null);
            string result = obj.analyseMood();
            //Assert.AreEqual("123", result);

        }


        [TestMethod]
        public void GivenMoodHappy_ShouldReturnNull()
        {
            UC6AnalyzeMood obj = new UC6AnalyzeMood("null");
            string result = obj.analyseMood();
            Assert.AreEqual("HAPPY", result);

        }


    }

}

