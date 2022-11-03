using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionOnUC6AnalyzeMood
{
    public class UC2InvalidMood
    {
        string message;

        public UC2InvalidMood() { }

        public UC2InvalidMood(string msg)
        {
            this.message = msg;
        }
        public string analyseMood()
        {
            try
            {
                if (this.message.Contains("Sad"))
                {
                    return "SAD";
                }
            }
            catch (NullReferenceException obj)
            {
                Console.WriteLine("Exception");
            }

            return "Happy";
        }
    }
}
