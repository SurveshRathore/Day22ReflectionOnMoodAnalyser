using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day20MoodAnalyzer
{
    public class RF1msgCons
    {
        string message;

        public RF1msgCons() { }

        public RF1msgCons(string msg) 
        { 
            this.message = msg; 
        }
        public string analyseMood()
        {
            if (this.message.Contains("Sad"))
            {
                return "SAD";
            }
            else
            {
                return "HAPPY";
            }
        }
    }
}
