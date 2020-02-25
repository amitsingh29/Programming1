//-----------------------------------------------------------------------
// <copyright file="InvalidMoodException.cs" company="BridgeLabz">
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
    /// InvalidMoodException class
    /// </summary>
    public class InvalidMoodException : Exception
    {
        /// <summary>
        /// overridden Message method
        /// </summary>
        public override string Message
        {
            get
            {
                return "Happy";
            }
        }
    }
}
