//-----------------------------------------------------------------------
// <copyright file="Laptop.cs" company="BridgeLabz">
//     Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Amit Singh"/>
//-----------------------------------------------------------------------using System;using System;

namespace DesignPattern.FactoryPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Laptop- class
    /// </summary>
    /// <seealso cref="DesignPattern.FactoryPattern.CFactory" />
    public class Laptop : CFactory
    {
        /// <summary>
        /// Functionalities the specified ram.
        /// </summary>
        /// <param name="ram">The ram.</param>
        /// <param name="processor">The processor.</param>
        /// <param name="operatingSystem">The operating system.</param>
        public void Functionality(string ram, string processor, string operatingSystem)
        {
            Console.WriteLine("Fnctionality of laptop :" + ram.ToString() + " Gb " + processor.ToString() + " GB " + operatingSystem.ToString());
        }

        /// <summary>
        /// Functionalities this instance.
        /// </summary>
        public void Functionality()
        {
            Console.WriteLine("Functionality Method");
        }
    }
}
