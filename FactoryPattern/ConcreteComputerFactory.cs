//-----------------------------------------------------------------------
// <copyright file="ConcreteComputerFactory.cs" company="BridgeLabz">
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
    /// ConcreteComputerFactory class
    /// </summary>
    /// <seealso cref="DesignPattern.FactoryPattern.ComputerFactory" />
    public class ConcreteComputerFactory : ComputerFactory
    {
        /// <summary>
        /// Gets the computer.
        /// </summary>
        /// <param name="Computer">The computer.</param>
        /// <returns></returns>
        /// <exception cref="ApplicationException"></exception>
        public override CFactory GetComputer(string Computer)
        {
            switch (Computer)
            {
                case "Laptop":
                return new Laptop();
                case "Server":
                return new Server();
                case "Pc":
                return new Pc();
                default:
                throw new ApplicationException(string.Format("Vehicle '{0}' cannot be created", Computer));
            }
        }
    }
}
