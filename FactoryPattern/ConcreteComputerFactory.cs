using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.FactoryPattern
{
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
            switch(Computer)
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
