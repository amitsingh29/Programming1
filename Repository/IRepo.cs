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
    using EmployeeManagement.Model;
    using System.Threading.Tasks;

    /// <summary>
    /// IRepo class
    /// </summary>
    public interface IRepo
    {
      /// <summary>
      /// </summary>
      /// <param name="emp"></param>
      /// <returns>If added True else False</returns>
        bool AddEmployee(Employee emp);

        /// <summary>
        /// </summary>
        /// <param name="emp"></param>
        /// <returns>If added True else False</returns>
        bool DeleteEmployee(int Id);

        /// <summary> 
        /// </summary>
        /// <returns>If added True else False</returns>
        List<Employee> GetAllEmployee();

        /// <summary> 
        /// </summary>
        /// <param name="emp"></param>
        /// <returns>If added True else False</returns>
        bool UpdateEmployee(Employee emp);
    }
}
