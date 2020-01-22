//-----------------------------------------------------------------------
// <copyright file="SocketAdapterImplementation.cs" company="BridgeLabz">
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
    /// SocketAdapterImplementation class
    /// </summary>
    /// <seealso cref="DesignPattern.StructuralDesignPattern.AdapterDesignPattern.Socket" />
    public class SocketAdapterImplementation : Socket
    {
        /// <summary>
        /// Get120s the v.
        /// </summary>
        /// <returns></returns>
        public Volt Get120V()
            {
                return GetVolt();
            }

        /// <summary>
        /// Get240s the volt.
        /// </summary>
        /// <returns></returns>
        public Volt Get240Volt()
            {
                Volt v = GetVolt();
                return ConvertVolt(v, 10);
            }

        /// <summary>
        /// Get3s the volt.
        /// </summary>
        /// <returns></returns>
        public Volt Get3Volt()
            {
                Volt v = GetVolt();
                return ConvertVolt(v, 40);
            }

        /// <summary>
        /// Converts the volt.
        /// </summary>
        /// <param name="v">The v.</param>
        /// <param name="i">The i.</param>
        /// <returns>
        /// </returns>
        private Volt ConvertVolt(Volt v, int i)
            {
                return new Volt(v.GetVolts() / i);
            } 
    }
}
