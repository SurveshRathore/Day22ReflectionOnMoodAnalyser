﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionOnUC6AnalyzeMood
{
    public class UC1AnalyzeMood
    {
        public string analyseMood(string msg)
        {
            if (msg.Contains("Sad"))
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
