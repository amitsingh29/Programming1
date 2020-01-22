//-----------------------------------------------------------------------
// <copyright file="CFactory.cs" company="BridgeLabz">
//     Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Amit Singh"/>
//-----------------------------------------------------------------------using System;

namespace DesignPattern.FactoryPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// CFactory Interface
    /// </summary>
    public interface CFactory
    {
        /// <summary>
        /// Functionalities the specified ram.
        /// </summary>
        /// <param name="ram">The ram.</param>
        /// <param name="processor">The processor.</param>
        /// <param name="operatingSystem">The operating system.</param>
        void Functionality(string ram, string processor, string operatingSystem);

        /// <summary>
        /// Functionalities this instance.
        /// </summary>
        void Functionality();
    }
}
