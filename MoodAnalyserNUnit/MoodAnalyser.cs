//-----------------------------------------------------------------------
// <copyright file="MoodAnalyser.cs" company="BridgeLabz">
//     Copyright © 2020
// </copyright>
// <creator name="Amit Singh"/>
//-----------------------------------------------------------------------

namespace MoodAnalyserNUnit
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;
    using System.Text;

    /// <summary>
    ///  MoodAnalyser class
    /// </summary>
    public class MoodAnalyser
    {
        /// <summary>
        /// string instance variable
        /// </summary>
        public string message;

        /// <summary>
        /// MoodAnalyser default constructor
        /// </summary>
        public MoodAnalyser()
        {
        }

        /// <summary>
        /// MoodAnalyser custom constructor
        /// </summary>
        /// <param name="message">string mood</param>
        public MoodAnalyser(string message)
        {
            this.message = message;
        }

        /// <summary>
        /// AnalyseMood method
        /// </summary>
        /// <returns>string value</returns>
        public string AnalyseMood()
        {
            try
            {
                if (this.message == "I'm in a bad mood")
                {
                    return "Sad";
                }

                if (this.message == string.Empty)
                {
                    throw new MoodAnalysisException(MoodAnalysisException.Exception_Type.Empty, "Empty Mood");
                }

                if (this.message == null)
                {
                    throw new MoodAnalysisException(MoodAnalysisException.Exception_Type.Null, "Null Mood");
                }

                return "Happy";
            }
            catch (MoodAnalysisException exception)
            {
                return exception.Message;
            }
        }
        /// <summary>
        /// Equals method
        /// </summary>
        /// <param name="obj">object obj</param>
        /// <returns>Boolean value</returns>
        public override bool Equals(Object obj)
        {
            object mood = MoodAnalyserFactory.MoodAnalyser("MoodAnalyser");

            if (mood.GetType() == obj.GetType())
            {
                return true;
            }

            return false;
        }
    }
}
