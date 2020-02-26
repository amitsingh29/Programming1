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
        public string message = "I'm in sad mood";

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
                if (this.message == string.Empty)
                {
                    throw new MoodAnalysisException(MoodAnalysisException.Exception_Type.Empty, "Empty Mood");
                }

                if (this.message == null)
                {
                    throw new MoodAnalysisException(MoodAnalysisException.Exception_Type.Null, "Null Mood");
                }

                if (message.Length < 3)
                {
                    throw new MoodAnalysisException(MoodAnalysisException.Exception_Type.NoSuchClass, "Plz Enter length of argument more than and equal to 3 ");
                }

                if (message.Contains("Sad"))
                {
                    return "Sad";
                }
            }

            catch (MoodAnalysisException exception)
            {
                return exception.Message;
            }
                return "Happy";
        }
        /// <summary>
        /// Equals method
        /// </summary>
        /// <param name="obj">object obj</param>
        /// <returns>Boolean value</returns>
        public override bool Equals(Object obj)
        {
            MoodAnalyser obj1 = new MoodAnalyser("Amit");

            if (obj.GetType() == obj1.GetType())
            {
                return true;
            }

            return false;
        }
    }
}
