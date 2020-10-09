using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzerProblem
{
    public class MoodAnalyze
    {
        private string message;
        public MoodAnalyze()
        {
        }        
        public MoodAnalyze(string message)
        {
            this.message = message;
        }
        public string analyzeMood(string message)
        {
            try
            {
                if (message.Contains("Sad"))
                    return "SAD";
                else
                    return "HAPPY";
            }
            catch
            {
                return "HAPPY";
            }
        }
        public string analyzeMood()
        {
            try
            {
                if (this.message.Contains("Sad"))
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
