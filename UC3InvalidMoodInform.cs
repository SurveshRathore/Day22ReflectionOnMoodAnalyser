using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day20MoodAnalyzer
{
    public class UC3InvalidMoodInform
    {
        string message;

        public UC3InvalidMoodInform() { }

        public UC3InvalidMoodInform(string msg)
        {
            this.message = msg;
        }
        public string analyseMood()
        {
            try
            {
                if (this.message.Equals(string.Empty))
                {
                    throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.EMPTY_MESSAGE, "Mood should not be empty");
                }
                if (this.message.Contains("Sad"))
                {
                    return "SAD";
                }
                else
                {
                    return "Happy";
                }
            }
            catch (NullReferenceException obj)
            {
                throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.NULL_MESSAGE, "Mood should not be null");
            }
            catch (MoodAnalyserCustomException ex)
            {
                Console.WriteLine("this is our custom exception");
            }
            finally
            {
                Console.WriteLine("This code will always execute irrespective of exception came or not!!!!");
            }
            return null;

        }
    }
}
