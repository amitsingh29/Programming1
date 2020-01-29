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

    /// <summary>
    ///  RepoEmployeeImplementation class
    /// </summary>
    /// <seealso cref="EmployeeManagement.Repository.IRepo" />
    public class RepoEmployeeImplementation : IRepo
    {
        string ConnectionString = "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = EmployeeManagement; Integrated Security = SSPI";
        
        /// <summary>
        /// AddEmployee details
        /// </summary>
        /// <param name="emp"></param>
        /// <returns></returns>
        public bool AddEmployee(Employee emp)
        {
            SqlConnection connection = new SqlConnection(this.ConnectionString);
            SqlCommand command = new SqlCommand("spAddEmployee", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@FullName", emp.FullName);
            command.Parameters.AddWithValue("@Age", emp.Age);
            command.Parameters.AddWithValue("@EmailId", emp.EmailId);
            command.Parameters.AddWithValue("@WorkExp", emp.WorkExperience);

            var result = command.ExecuteNonQuery();
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
        /// DeleteEmployee
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public bool DeleteEmployee(int id)
        {
            SqlConnection connection = new SqlConnection(this.ConnectionString);
            SqlCommand command = new SqlCommand("spDeleteEmployee", connection);
            command.CommandType = CommandType.StoredProcedure;
            Employee emp = new Employee();

            command.Parameters.AddWithValue("@Id", emp.Id);

            var result = command.ExecuteNonQuery();
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
        /// <returns></returns>
        public List<Employee> GetAllEmployee()
        {
            SqlConnection connection = new SqlConnection(this.ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;

            List<Employee> employeeList = new List<Employee>();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Employee employee = new Employee
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    FullName = reader["FullName"].ToString(),
                    Age = reader["Age"].ToString(),
                    EmailId = reader["EmailId"].ToString(),
                    WorkExperience = Convert.ToInt32(reader["WorkExp"])
                };

                employeeList.Add(employee);
            }

            return employeeList;
        }

        /// <summary>
        /// Update Employee details
        /// </summary>
        /// <param name="emp"></param>
        /// <returns></returns>
        public bool UpdateEmployee(Employee emp)
        {
            SqlConnection connection = new SqlConnection(this.ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@Id", emp.Id);
            command.Parameters.AddWithValue("@FullName", emp.FullName);
            command.Parameters.AddWithValue("@Age", emp.Age);
            command.Parameters.AddWithValue("@EmailId", emp.EmailId);
            command.Parameters.AddWithValue("@WorkExp", emp.WorkExperience);

            var result = command.ExecuteNonQuery();
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
