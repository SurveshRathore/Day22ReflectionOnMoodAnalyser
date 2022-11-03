using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionOnUC6AnalyzeMood
{
    public class UC6AnalyzeMood
    {
        private string message;
        public UC6AnalyzeMood(string message)
        {
            this.message = message;
        }
        public UC6AnalyzeMood()
        {

        }
        public string analyseMood()
        {
            try
            {
                if (this.message.Equals(string.Empty))
                {
                    throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.EMPTY_MESSAGE, "Mood should not be empty");
                }
                if (this.message.Contains("sad"))
                    return "SAD";
                else
                    return "HAPPY";
            }
            catch (NullReferenceException obj)
            {
                //throw new Exception(obj.Message);

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
