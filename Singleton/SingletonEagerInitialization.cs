//-----------------------------------------------------------------------
// <copyright file="SingletonEagerInitialization.cs" company="BridgeLabz">
//     Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Amit Singh"/>
//-----------------------------------------------------------------------using System;

namespace DesignPattern.Singleton
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// SingletonEagerInitialization class
    /// </summary>
    public class SingletonEagerInitialization
    {
        /// <summary>
        /// The initialization
        /// </summary>
        private static SingletonEagerInitialization initialization = new SingletonEagerInitialization();

        /// <summary>
        /// Prevents a default instance of the <see cref="SingletonEagerInitialization"/> class from being created.
        /// </summary>
        private SingletonEagerInitialization()
        {
            Console.WriteLine("Singleton Object");
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        /// <returns></returns>
        public static SingletonEagerInitialization GetSingleton
        {
            get
            {
                return initialization;
            }   
        }
    }
}
