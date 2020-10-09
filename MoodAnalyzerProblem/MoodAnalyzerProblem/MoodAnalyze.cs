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
                if (message.Equals(string.Empty))
                    throw new MoodAnalyzerException(MoodAnalyzerException.ExceptionType.EMPTY_MESSAGE, "Mood should not be empty");
                if (message.Contains("Sad"))
                    return "SAD";
                else
                    return "HAPPY";
            }
            catch (NullReferenceException)
            {
                throw new MoodAnalyzerException(MoodAnalyzerException.ExceptionType.NULL_MESSAGE, "Mood should not be null");
            }
        }
        public string analyzeMood()
        {
            try
            {
                if (this.message.Equals(string.Empty))
                    throw new MoodAnalyzerException(MoodAnalyzerException.ExceptionType.EMPTY_MESSAGE, "Mood should not be empty");
                if (this.message.Contains("Sad"))
                    return "SAD";
                else
                    return "HAPPY";
            }
            catch(NullReferenceException)
            {
                throw new MoodAnalyzerException(MoodAnalyzerException.ExceptionType.NULL_MESSAGE, "Mood should not be null");
            }
        }
    }
}
