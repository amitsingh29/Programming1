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
        /// custom constructor
        /// </summary>
        /// <param name="Type">Exception_Type type</param>
        /// <param name="message">string message</param>
        public MoodAnalysisException(Exception_Type type, string message)
        {
            this.Type = type;
            this.message = message;
        }

        /// <summary>
        /// enum
        /// </summary>
        public enum Exception_Type
        {
            /// <summary>
            /// Empty Exception_Type
            /// </summary>
            Empty,

            /// <summary>
            /// Null Exception_Type
            /// </summary>
            Null,

            /// <summary>
            /// NoSuchClass Exception_Type
            /// </summary>
            NoSuchClass,

            /// <summary>
            /// NoSuchMethod Exception_Type
            /// </summary>
            NoSuchMethod,

            /// <summary>
            /// NoSuchField Exception_Type
            /// </summary>
            NoSuchField
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
