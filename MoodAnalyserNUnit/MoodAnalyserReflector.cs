//-----------------------------------------------------------------------
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
    public class MoodAnalyserReflector
    {
        /// <summary>
        /// static check variable
        /// </summary>
        public static string check;

        /// <summary>
        /// CreateObject method with single parameter
        /// </summary>
        /// <param name="classNames"></param>
        /// <returns></returns>
        public static object CreateObject(string classNames)
        {
            try
            {
                Type type = Type.GetType("MoodAnalyser." + classNames);
                if (type != null)
                {
                    object obj = Activator.CreateInstance(type);
                    return obj;
                }

                throw new MoodAnalysisException(MoodAnalysisException.Exception_Type.NoSuchClass, "No such class");
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        /// <summary>
        /// MoodAnalyser method with multiple parameters
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

        /// <summary>
        /// Method which checks the name
        /// </summary>
        /// <param name="methodName">string parameter</param>
        /// <returns>string type</returns>
        public static string WrongMethod(string methodName)
        {
            MoodAnalyser moodAnalyser = (MoodAnalyser)MoodAnalyserReflector.MoodAnalyser("MoodAnalyser", "Happy");
            MethodInfo methodInfo = moodAnalyser.GetType().GetMethod(methodName);
            try
            {
                if (methodInfo == null)
                {
                    throw new MoodAnalysisException(MoodAnalysisException.Exception_Type.NoSuchMethod, "No Such Method");
                }

                return methodName;
            }
            catch (MoodAnalysisException ex)
            {
                return ex.Message;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        /// <param name="fieldName"></param>
        /// <returns></returns>
        public static string SetField(string message, string fieldName)
        {
            try
            {
                if (fieldName == "check")
                {
                    check = message;
                    if (check == null)
                    {
                        throw new MoodAnalysisException(MoodAnalysisException.Exception_Type.Null, "Null");
                    }

                    FieldInfo fieldInfo = typeof(MoodAnalyserReflector).GetField("check");
                    return fieldInfo.GetValue(null).ToString();
                }

                throw new MoodAnalysisException(MoodAnalysisException.Exception_Type.NoSuchField, "No Such Field");
            }
            catch (MoodAnalysisException ex)
            {
                return ex.Message;
            }
        }
    }
}
