//-----------------------------------------------------------------------
// <copyright file="ComputerFactory.cs" company="BridgeLabz">
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
    /// ComputerFactory class
    /// </summary>
    public abstract class ComputerFactory
     {
        /// <summary>
        /// Gets the computer.
        /// </summary>
        /// <param name="Computer">The computer.</param>
        /// <returns></returns>
        public abstract CFactory GetComputer(string Computer);
     }
}
