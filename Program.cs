//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="BridgeLabz">
//     Copyright © 2020
// </copyright>
// <creator name="Amit Singh Bhakuni"/>
//-----------------------------------------------------------------------

[assembly: log4net.Config.XmlConfigurator(Watch = true)]

namespace LoggerFile
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Program class
    /// </summary>
    public class Program
    {
        /// <summary>
        /// The log
        /// </summary>
        private static readonly log4net.ILog log = LogHelper.GetLogger();

        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
       public static void Main(string[] args)
        {
           Console.WriteLine("Hello Amit");
            log.Error("This is my error message");
            Console.ReadLine();             
        }
    }
}
