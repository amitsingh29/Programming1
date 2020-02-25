using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace MoodAnalyserNUnit
{
    public class MoodAnalyserFactory
    {
        public MoodAnalyserFactory()
        {

        }
        public static object MoodAnalyser(string className)
        {
            Type type = Type.GetType("MoodAnalyserNUnit." + className);
            try
            {
                if (type != null)
                {
                   object obj = Activator.CreateInstance(type);
                    return obj;
                }
                throw new MoodAnalysisException(MoodAnalysisException.Exception_Type.NoSuchClass, "No Such Class");
            }
            catch (MoodAnalysisException exception)
            {
                return exception.Message;
            } 
        }
    }
}
