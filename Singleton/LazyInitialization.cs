using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Singleton
{
    class LazyInitialization
    {
        public static LazyInitialization obj;
        private LazyInitialization()
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static LazyInitialization GetObj()
        {
                if (obj == null)
                {
                    obj = new LazyInitialization();
                }
                return obj;
            }
         
        }
    }

