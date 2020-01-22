//-----------------------------------------------------------------------
// <copyright file="Developer.cs" company="BridgeLabz">
//     Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Amit Singh"/>
//-----------------------------------------------------------------------using System;using System;

namespace DesignPattern.PrototypeDesignPattern
{
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Developer class
    /// </summary>
    /// <seealso cref="DesignPattern.PrototypeDesignPattern.IEmployee" />
    public class Developer : IEmployee
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the age.
        /// </summary>
        /// <value>
        /// The age.
        /// </value>
        public int Age { get; set; }

        /// <summary>
        /// Gets or sets the technology.
        /// </summary>
        /// <value>
        /// The technology.
        /// </value>
        public string Technology { get; set; }

        /// <summary>
        /// Clones this instance.
        /// </summary>
        /// <returns></returns>
        public IEmployee Clone()
        {
            return (IEmployee)MemberwiseClone();
        }

        /// <summary>
        /// Clones this instance.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public IEmployee clone()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Emps the details.
        /// </summary>
        /// <returns></returns>
        public string EmpDetails()
        {
            return string.Format("{0}-{1}-{2}", this.Name, this.Age, this.Technology);
        }
    }
}
