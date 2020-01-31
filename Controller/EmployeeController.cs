//-----------------------------------------------------------------------
// <copyright file="EmployeeController.cs" company="BridgeLabz">
//     Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Amit Singh"/>
//-----------------------------------------------------------------------

namespace EmployeeManagement.Controller
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using EmployeeManagement.Manager;
    using EmployeeManagement.Model;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;

    /// <summary>
    /// EmployeeController class
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.ControllerBase" />
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        /// <summary>
        /// The manager
        /// </summary>
       private IManager manager = new ImplementingIManagerDetails();

        /// <summary>
        /// Deletes the employee.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>boolean value</returns>
        [HttpDelete]
        [Route("api/delete")]
        public IActionResult DeleteEmployee(int id)
        {
            var check = this.manager.DeleteEmployee(id);
            if (check)
            {
                return this.Ok(check);
            }
            else
            {
                return this.BadRequest("error in deletion");
            }
        }

        /// <summary>
        /// Adds the employee.
        /// </summary>
        /// <param name="employee">The employee.</param>
        /// <returns>boolean value</returns>
        [HttpPost]
        [Route("api/add")]
        public IActionResult AddEmployee(Employee employee)
        {
            var check = this.manager.AddEmployee(employee);
            if (check)
            {
                return this.Ok(check);
            }
            else
            {
                return this.BadRequest("error in adding");
            }
        }

        /// <summary>
        /// Updates the employee.
        /// </summary>
        /// <param name="employee">The employee.</param>
        /// <returns>boolean value</returns>
        [HttpPut]
        [Route("api/update")]
        public IActionResult UpdateEmployee(Employee employee)
        {
            var check = this.manager.UpdateEmployee(employee);
            if (check)
            {
                return this.Ok(check);
            }
            else
            {
                return this.BadRequest("error in deletion");
            }
        }
    }
}