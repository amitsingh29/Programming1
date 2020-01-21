using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Singleton
{
    class ThreadSafeSingleton
    {
        private static ThreadSafeSingleton obj;
        private static object obj1=new object();

        /// <summary>
        /// Prevents a default instance of the <see cref="ThreadSafeSingleton"/> class from being created.
        /// </summary>
        private ThreadSafeSingleton()
        {
            Console.WriteLine("Instance created");
        }
        public static ThreadSafeSingleton GetObj
        {
            get
            {
               lock(obj1)
                {
                    if (obj == null)
                    {
                        obj = new ThreadSafeSingleton();
                    }
                    return obj;
                }
            }   
        }
    }
}
