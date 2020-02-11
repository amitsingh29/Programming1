//-----------------------------------------------------------------------
// <copyright file="LogHelper.cs" company="BridgeLabz">
//     Copyright © 2020
// </copyright>
// <creator name="Amit Singh Bhakuni"/>
//-----------------------------------------------------------------------

namespace LoggerFile
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// LogHelper class
    /// </summary>
    public class LogHelper
    {
        /// <summary>
        /// GetLogger method
        /// </summary>
        /// <param name="filename">string</param>
        /// <returns>return's filename</returns>
        public static log4net.ILog GetLogger([CallerFilePath]string filename = " ")
        {
            return log4net.LogManager.GetLogger(filename);
        }
    }
}
