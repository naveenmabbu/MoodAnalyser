﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    public class MoodAnalyse
    {
        private string message;
        public MoodAnalyse(string message)
        {
            this.message = message;
        }
        public string AnalyserMethod()
        {
            try
            {
                if (this.message.Contains("SAD"))
                    return "SAD";
                else if (this.message.Contains("HAPPY"))
                    return "SAD";
                else
                    return "HAPPY";
            }
            catch
            {
                return "HAPPY";
            }
        }
    }
}
