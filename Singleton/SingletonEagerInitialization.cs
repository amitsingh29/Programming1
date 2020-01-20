using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Singleton
{
    class SingletonEagerInitialization
    {
        private static SingletonEagerInitialization initialization = new SingletonEagerInitialization();
        private SingletonEagerInitialization()
        {

        }
        /// <summary>
        /// Gets the singleton.
        /// </summary>
        /// <returns></returns>
        public static SingletonEagerInitialization GetSingleton()
        {
            return initialization;
        }
    }
}
