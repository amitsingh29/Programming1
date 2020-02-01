//-----------------------------------------------------------------------
// <copyright file="Employee.cs" company="BridgeLabz">
//     Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Amit Singh"/>
//-----------------------------------------------------------------------

namespace EmployeeManagement.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>
    /// Employee class
    /// </summary>
    public class Employee
    {
        /// <summary>
        /// The identifier
        /// </summary>
        private int id;

        /// <summary>
        /// The full name
        /// </summary>
        private string fullName;

        /// <summary>
        /// The email identifier
        /// </summary>
        private string emailId;

        /// <summary>
        /// The age
        /// </summary>
        private string age;

        /// <summary>
        /// The work experience
        /// </summary>
        private int workExperience;

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name
        {
            get
            {
                return this.Name;
            }

            set
            {
                this.Name = value;
            }
        }

        /// <summary>
        /// Gets or sets the age.
        /// </summary>
        /// <value>
        /// The age.
        /// </value>
        public string AgeEmployee
        {
            get
            {
                return this.AgeEmployee;
            }

            set
            {
                this.AgeEmployee = value;
            }
        }

        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        /// <value>
        /// The email.
        /// </value>
        public string Email
        {
            get
            {
                return this.Email;
            }

            set
            {
               this.Email = value;
            }
        }
      
        /// <summary>
        /// Gets or sets the experience.
        /// </summary>
        /// <value>
        /// The experience.
        /// </value>
        public string Experience
        {
            get
            {
                return this.Experience;
            }

            set
            {
               this.Experience = value;
            }
        }
    }
}
