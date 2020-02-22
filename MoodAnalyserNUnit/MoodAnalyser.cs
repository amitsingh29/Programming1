using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyserNUnit
{
    public class MoodAnalyser
    {
       public string AnalyseMood(string message)
        {
            if(message == "I'm in sad mood")
            {
                return "Sad";
            }

            return "Happy";
        }
    }
}
