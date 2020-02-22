using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyserNUnit
{
    public class InvalidMoodException : Exception
    {
        public override string Message
        {
            get
            {
                return "Happy";
            }
        }
    }
}
