using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.PrototypeDesignPattern
{
   public interface IEmployee
    {
        /// <summary>
        /// Clones this instance.
        /// </summary>
        /// <returns></returns>
        public IEmployee clone();

        /// <summary>
        /// Emps the details.
        /// </summary>
        /// <returns></returns>
        public string empDetails();
    }
}
