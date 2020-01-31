//-----------------------------------------------------------------------
// <copyright file="IManager.cs" company="BridgeLabz">
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

    /// <summary>
    /// IManager class
    /// </summary>
    public interface IManager
    {
        /// <summary>
        /// Adds the employee.
        /// </summary>
        /// <param name="employee">The employee.</param>
        /// <returns>boolean value</returns>
        bool AddEmployee(Employee employee);

        /// <summary>
        /// Deletes the employee.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>boolean value</returns>
        bool DeleteEmployee(int id);

        /// <summary>
        /// Gets all employee.
        /// </summary>
        /// <returns>employee list</returns>
        List<Employee> GetAllEmployee();

        /// <summary>
        /// Updates the employee.
        /// </summary>
        /// <param name="employee">The employee.</param>
        /// <returns>boolean value</returns>
        bool UpdateEmployee(Employee employee);
    }
}
