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
            this.message = message;
        }
        
        public string AnalyseMood()
        {
            try
            {
                if(message == "I'm in a bad mood")
                {
                    return "Sad";
                }
                if(message == string.Empty)
                {
                    throw new MoodAnalysisException(MoodAnalysisException.Exception_Type.Empty, "Empty Mood");
                }
                if(message == null)
                {
                    throw new MoodAnalysisException(MoodAnalysisException.Exception_Type.Null, "Null Mood");
                }

                return "Happy";
            }
            catch(MoodAnalysisException exception)
            {
                return exception.Message;
            }   
        }
    }
     
}

