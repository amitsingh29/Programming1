using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.StructuralDesignPattern.AdapterDesignPattern
{
    public class Socket
    {
        /// <summary>
        /// Gets the volt.
        /// </summary>
        /// <returns></returns>
        public Volt GetVolt()
        {
            return new Volt(120);
        }
    }
}
