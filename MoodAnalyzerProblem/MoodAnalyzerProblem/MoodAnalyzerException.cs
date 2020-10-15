using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzerProblem
{
    public class MoodAnalyzerException : Exception
    {
        public enum ExceptionType
        {
            NULL_MESSAGE, EMPTY_MESSAGE, NO_SUCH_CLASS, NO_SUCH_METHOD
        }
        private readonly ExceptionType type;
        public MoodAnalyzerException(ExceptionType type,string message) : base(message)
        {
            this.type = type;
        } 
    }
}
