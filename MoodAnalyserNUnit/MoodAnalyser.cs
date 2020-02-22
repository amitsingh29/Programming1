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
            this.message = "";
        }
        public string AnalyseMood()
        {
            try
            {
                if (message == "I'm in a sad mood")
                {
                    return "Sad";
                }
                else if (message == null)
                {
                    throw new InvalidMoodException();
                }
            }
            catch (InvalidMoodException exception)
            {
                Console.WriteLine(exception.Message);
            }
            return "Happy";
        }
    }
}
