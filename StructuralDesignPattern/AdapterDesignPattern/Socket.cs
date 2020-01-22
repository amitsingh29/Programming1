//-----------------------------------------------------------------------
// <copyright file="Socket.cs" company="BridgeLabz">
//     Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Amit Singh"/>
//-----------------------------------------------------------------------using System;
//-----------------------------------------------------------------------
// <copyright file="Server.cs" company="BridgeLabz">
//     Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Amit Singh"/>
//-----------------------------------------------------------------------using System;
namespace DesignPattern.StructuralDesignPattern.AdapterDesignPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Socket class
    /// </summary>
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
