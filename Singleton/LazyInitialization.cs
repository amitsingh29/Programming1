//-----------------------------------------------------------------------
// <copyright file="LazyInitialization.cs" company="BridgeLabz">
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
    /// Lazy Initialization
    /// </summary>
    public class LazyInitialization
    {
        /// <summary>
        /// The object
        /// </summary>
        private static LazyInitialization Object;

        /// <summary>
        /// Prevents a default instance of the <see cref="LazyInitialization"/> class from being created.
        /// </summary>
        private LazyInitialization()
        {
            Console.WriteLine("LazyInitialization constructor");
        }

        /// <summary>
        /// Gets the object.
        /// </summary>
        /// <returns></returns>
        public static LazyInitialization GetObject
        {
            get
            {
                if (Object == null)
                {
                    Object = new LazyInitialization();
                }

                return Object;
            }  
        }
    }
}
