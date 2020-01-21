//-----------------------------------------------------------------------
// <copyright file="ThreadSafeSingleton.cs" company="BridgeLabz">
//     Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Amit Singh"/>
//-----------------------------------------------------------------------

namespace DesignPattern.Singleton
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Thread class
    /// </summary>
    public class ThreadSafeSingleton
    {
        /// <summary>
        /// The instance
        /// </summary>
        private static ThreadSafeSingleton instance;

        /// <summary>
        /// The lock object
        /// </summary>
        private static object lockObject = new object();

        /// <summary>
        /// Prevents a default instance of the <see cref="ThreadSafeSingleton"/> class from being created.
        /// </summary>
        private ThreadSafeSingleton()
        {
            Console.WriteLine("Instance created");
        }

        /// <summary>
        /// Gets the get instance.
        /// </summary>
        /// <value>
        /// The get instance.
        /// </value>
        public static ThreadSafeSingleton GetInstance
        {
            get
            {
                lock (lockObject)
                {
                    if (instance == null)
                    {
                        instance = new ThreadSafeSingleton();
                    }

                    return instance;
                }
            }   
        }
    }
}
