//-----------------------------------------------------------------------
// <copyright file="ISocketAdapter.cs" company="BridgeLabz">
//     Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Amit Singh"/>
//-----------------------------------------------------------------------

namespace DesignPattern.StructuralDesignPattern.AdapterDesignPattern
{
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// ISocketAdapter Interface
    /// </summary>
    public interface ISocketAdapter
    {
    /// <summary>
    /// ISocketAdapter Interface
    /// </summary>
    /// <returns></returns>
        public Volt Get3Volt();

        /// <summary>
        /// Get120s the volt.
        /// </summary>
        /// <returns></returns>
        public Volt Get120Volt();

        /// <summary>
        /// Get240s the volt.
        /// </summary>
        /// <returns></returns>
        public Volt Get240Volt();
    }
}
