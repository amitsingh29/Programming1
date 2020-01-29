//-----------------------------------------------------------------------
// <copyright file="IManager.cs" company="BridgeLabz">
//     Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Amit Singh"/>
//-----------------------------------------------------------------------

namespace EmployeeManagement.Manager
{
    using EmployeeManagement.Model;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>
    /// IManager class
    /// </summary>
    public interface IManager
    {
        /// <summary>
        /// Adds the employee.
        /// </summary>
        /// <param name="emp">The emp.</param>
        /// <returns></returns>
        bool AddEmployee(Employee emp);

        /// <summary>
        /// Deletes the employee.
        /// </summary>
        /// <param name="Id">The identifier.</param>
        /// <returns></returns>
        bool DeleteEmployee(int Id);

        /// <summary>
        /// Gets all employee.
        /// </summary>
        /// <returns></returns>
        List<Employee> GetAllEmployee();

        /// <summary>
        /// Updates the employee.
        /// </summary>
        /// <param name="emp">The emp.</param>
        /// <returns></returns>
        bool UpdateEmployee(Employee emp);
    }
}
