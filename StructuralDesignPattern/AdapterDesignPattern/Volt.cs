//-----------------------------------------------------------------------
// <copyright file="Volt.cs" company="BridgeLabz">
//     Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Amit Singh"/>
//-----------------------------------------------------------------------

namespace DesignPattern.StructuralDesignPattern.AdapterDesignPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Volt class
    /// </summary>
    public class Volt
    {
        /// <summary>
        /// The volts
        /// </summary>
        private int volts;

        /// <summary>
        /// Initializes a new instance of the <see cref="Volt"/> class.
        /// </summary>
        /// <param name="v">The v.</param>
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
        /// Gets the volts.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        internal int GetVolts()
        {
            throw new NotImplementedException();
        }
    }
}
