﻿//-----------------------------------------------------------------------
// <copyright file="MoodAnalyserFactory.cs" company="BridgeLabz">
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
    ///  MoodAnalyserFactory class
    /// </summary>
    public class MoodAnalyserFactory
    {
  
        /// <summary>
        /// MoodAnalyser method
        /// </summary>
        /// <param name="className">string parameter</param>
        /// <returns>object type</returns>
        public static object MoodAnalyser(string className, params object[] p)
        {
            try
            {
                Type type = Type.GetType("MoodAnalyserNUnit." + className);
                if (type != null)
                {
                    object obj = Activator.CreateInstance(type, p);
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
