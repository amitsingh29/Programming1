//-----------------------------------------------------------------------
// <copyright file="RepoEmployeeImplementation.cs" company="BridgeLabz">
//     Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Amit Singh"/>
//-----------------------------------------------------------------------

namespace EmployeeManagement.Repository
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SqlClient;
    using EmployeeManagement.Model;
    using Newtonsoft.Json.Linq;
   
    /// <summary>
    ///  RepoEmployeeImplementation class
    /// </summary>
    /// <seealso cref="EmployeeManagement.Repository.IRepo" />
    public class RepoEmployeeImplementation : IRepo
    {
        /// <summary>
        /// The connection string
        /// </summary>
        private readonly string connectionString = "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = EmployeeManagement; Integrated Security = SSPI";

        /// <summary>
        /// AddEmployee details
        /// </summary>
        /// <param name="employee">Add employee</param>
        /// <returns>Boolean value</returns>
        public bool AddEmployee(Employee employee)
        {
            SqlConnection connection = new SqlConnection(this.connectionString);
            SqlCommand command = new SqlCommand("spAddEmployee", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@FullName", employee.FullName);
            command.Parameters.AddWithValue("@Age", employee.Age);
            command.Parameters.AddWithValue("@EmailId", employee.EmailId);
            command.Parameters.AddWithValue("@WorkExp", employee.WorkExp);

            connection.Open();
            var result = command.ExecuteNonQuery();
            connection.Close();
            if (result == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Delete Employee
        /// </summary>
        /// <param name="id">employee id</param>
        /// <returns>Boolean value</returns>
        public bool DeleteEmployee(int id)
        {
            SqlConnection connection = new SqlConnection(this.connectionString);
            SqlCommand command = new SqlCommand("spDeleteEmployee", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Id", id);
            connection.Open();
            var result = command.ExecuteNonQuery();
            connection.Close();
            if (result == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Gets full list of Employee's
        /// </summary>
        /// <returns>Employee full list</returns>
        public List<Employee> GetAllEmployee()
        {
            SqlConnection connection = new SqlConnection(this.connectionString);
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;

            List<Employee> employeeList = new List<Employee>();

            SqlDataReader reader = command.ExecuteReader();
            connection.Open();
            while (reader.Read())
            {
                Employee employee = new Employee
                {
                    Id = reader["Id"].ToString(),
                    FullName = reader["FullName"].ToString(),
                    Age = reader["Age"].ToString(),
                    EmailId = reader["EmailId"].ToString(),
                    WorkExp = Convert.ToInt32(reader["WorkExp"].ToString())
                };

                employeeList.Add(employee);
                connection.Close();
            }

            return employeeList;
        }

        /// <summary>
        /// Updates the employee.
        /// </summary>
        /// <param name="employee">The employee.</param>
        /// <returns>
        /// Boolean value
        /// </returns>
        public bool UpdateEmployee(Employee employee)
        {
            SqlConnection connection = new SqlConnection(this.connectionString);
            SqlCommand command = new SqlCommand("spUpdateEmployee", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Id", employee.Id);
            command.Parameters.AddWithValue("@FullName", employee.FullName);
            command.Parameters.AddWithValue("@Age", employee.Age);
            command.Parameters.AddWithValue("@EmailId", employee.EmailId);
            command.Parameters.AddWithValue("@WorkExp", employee.WorkExp);
            connection.Open();
            var result = command.ExecuteNonQuery();
            connection.Close();
            if (result == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
