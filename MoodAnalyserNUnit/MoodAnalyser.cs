using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyserNUnit
{
    public class MoodAnalyser
    {
        string message;
        public MoodAnalyser()
        {

        }
        public MoodAnalyser(string message)
        {
            this.message = "I am in sad mood";
        }
       public string AnalyseMood()
       {
            if(message == "I am in sad mood")
            {
                return "Sad";
            }

            return "Happy";
       }
    }
}
