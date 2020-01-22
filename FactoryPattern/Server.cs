//-----------------------------------------------------------------------
// <copyright file="Server.cs" company="BridgeLabz">
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
    /// Server class
    /// </summary>
    /// <seealso cref="DesignPattern.FactoryPattern.CFactory" />
    public class Server : CFactory
    {
        /// <summary>
        /// Functionalities the specified ram.
        /// </summary>
        /// <param name="ram">The ram.</param>
        /// <param name="processor">The processor.</param>
        /// <param name="operatingSystem">The operating system.</param>
        public void Functionality(string ram, string processor, string operatingSystem)
        {
            Console.WriteLine("Functionality of server :" + ram.ToString() + " Gb " + processor.ToString() + " Gb " + operatingSystem.ToString());
        }

        /// <summary>
        /// Functionalities this instance.
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public void Functionality()
        {
            throw new NotImplementedException();
        }
      
        /// <summary>
        /// Functionalities this instance.
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public void functionality(string ram, string processor, string os)
        {
            throw new NotImplementedException();
        }

        public void functionality()
        {
            throw new NotImplementedException();
        }
    }
}
