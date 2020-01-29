﻿//-----------------------------------------------------------------------
// <copyright file=" ImplementingIManagerDetails.cs" company="BridgeLabz">
//     Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Amit Singh"/>
//-----------------------------------------------------------------------

namespace EmployeeManagement.Manager
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using EmployeeManagement.Model;
    using EmployeeManagement.Repository;

    /// <summary>
    /// ImplementingIManagerDetails class
    /// </summary>
    /// <seealso cref="EmployeeManagement.Manager.IManager" />
    public class ImplementingIManagerDetails : IManager
    {
        /// <summary>
        /// Repo Employee Implementation object created
        /// </summary>
        private RepoEmployeeImplementation repo = new RepoEmployeeImplementation();

        /// <summary>
        /// Gets all employee.
        /// </summary>
        /// <returns> Gets Employee </returns>
        public List<Employee> GetAllEmployee()
        {
            var result = this.repo.GetAllEmployee();
            return result;
        }

       /// <summary>
       /// Deletes employee with given id
       /// </summary>
       /// <param name="id"></param>
       /// <returns>Boolean value</returns>
        public bool DeleteEmployee(int id)
        {
            var result = this.repo.DeleteEmployee(id);
            return result;
        }

        /// <summary>
        /// Adds the employee.
        /// </summary>
        /// <param name="employee">The employee.</param>
        /// <returns>Boolean value</returns>
        public bool AddEmployee(Employee employee)
        {
            var result = this.repo.AddEmployee(employee);
            return result;
        }

        /// <summary>
        /// Updates the employee.
        /// </summary>
        /// <param name="employee">The employee.</param>
        /// <returns>Boolean value</returns>
        public bool UpdateEmployee(Employee employee)
        {
            var result = this.repo.UpdateEmployee(employee);
            return result;
        }
    }
}