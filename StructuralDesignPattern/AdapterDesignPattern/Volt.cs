using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.StructuralDesignPattern.AdapterDesignPattern
{
    public class Volt
    {
        private int volts;
        public Volt(int v)
        {
            this.volts = v;
        }

        /// <summary>
        /// Sets the volts.
        /// </summary>
        /// <param name="volts">The volts.</param>
        public void SetVolts(int volts)
        {
            this.volts = volts;
        }
        /// <summary>
        /// Getvoltses this instance.
        /// </summary>
        /// <returns></returns>
        public int GetVolts()
        {
            return volts;
        }
    }
}
