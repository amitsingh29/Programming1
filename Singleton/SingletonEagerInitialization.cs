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
        public static SingletonEagerInitialization GetSingleton()
        {
            return initialization;
        }
    }
}
