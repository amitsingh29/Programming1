//-----------------------------------------------------------------------
// <copyright file="IRepo.cs" company="BridgeLabz">
//     Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Amit Singh"/>
//-----------------------------------------------------------------------

namespace EmployeeManagement.Repository
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using EmployeeManagement.Model;
   
    /// <summary>
    /// IRepo class
    /// </summary>
    public interface IRepo
    {
        /// <summary>
        /// Adds the employee.
        /// </summary>
        /// <param name="employee">The employee.</param>
        /// <returns>Boolean value</returns>
        bool AddEmployee(Employee employee);

        /// <summary>
        /// Deletes the employee.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>Boolean value</returns>
        bool DeleteEmployee(int id);

        /// <summary>
        /// Gets all employee.
        /// </summary>
        /// <returns>Get list</returns>
        List<Employee> GetAllEmployee();

        /// <summary>
        /// Updates the employee.
        /// </summary>
        /// <param name="employee">The employee.</param>
        /// <returns>Boolean value</returns>
        bool UpdateEmployee(Employee employee);
    }
}
