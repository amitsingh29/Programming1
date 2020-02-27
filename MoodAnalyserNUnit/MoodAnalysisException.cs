//-----------------------------------------------------------------------
// <copyright file="MoodAnalysisException.cs" company="BridgeLabz">
//     Copyright © 2020
// </copyright>
// <creator name="Amit Singh"/>
//-----------------------------------------------------------------------

namespace MoodAnalyserNUnit
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    ///  MoodAnalysisException class
    /// </summary>
    public class MoodAnalysisException : Exception
    {
        /// <summary>
        /// string instance variable
        /// </summary>
        public string message;

        /// <summary>
        /// Exception_Type instance variable
        /// </summary>
        public Exception_Type Type;

        /// <summary>
        /// enum
        /// </summary>
        public enum Exception_Type
        {
            /// <summary>
            /// Emptymood Exception_Type
            /// </summary>
            Empty,

            /// <summary>
            /// NullMood Exception_Type
            /// </summary>
            Null,

            /// <summary>
            /// NoSuchClass Exception_Type
            /// </summary>
            NoSuchClass,
            
            NoSuchMethod,
            NoSuchField
        }

        /// <summary>
        /// custom constructor
        /// </summary>
        /// <param name="Type">Exception_Type typ</param>
        /// <param name="message">string messag</param>
        public MoodAnalysisException(Exception_Type type, string message)
        {
            this.Type = type;
            this.message = message;

        }

        /// <summary>
        /// overridden Message method
        /// </summary>
        public override string Message
        {
            get
            {
                return this.message;
            }
        }
    }
}
