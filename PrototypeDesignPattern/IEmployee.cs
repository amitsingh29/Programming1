//-----------------------------------------------------------------------
// <copyright file="IEmployee.cs" company="BridgeLabz">
//     Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Amit Singh"/>
//-----------------------------------------------------------------------using System;

namespace DesignPattern.PrototypeDesignPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// IEmployee Interface
    /// </summary>
    public interface IEmployee
    {
        /// <summary>
        /// Clones this instance.
        /// </summary>
        /// <returns></returns>
        public IEmployee clone();

        /// <summary>
        /// Emps the details.
        /// </summary>
        /// <returns></returns>
        public string EmpDetails();
    }
}
