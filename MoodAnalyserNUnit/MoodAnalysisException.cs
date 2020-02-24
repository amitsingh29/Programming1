using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyserNUnit
{
    public class MoodAnalysisException : Exception
    {
        public string message;
        public enum Exception_Type
        {
             Empty , Null
        }
        public Exception_Type type;
        public MoodAnalysisException(Exception_Type type , string message)
        {
            this.type = type;
            this.message = message;

        }
        public override string Message
        {
            get
            {
                return message;
            }
        }
    }
}
