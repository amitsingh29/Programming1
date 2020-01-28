//-----------------------------------------------------------------------
// <copyright file="IRepo.cs" company="BridgeLabz">
//     Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Amit Singh"/>
//-----------------------------------------------------------------------

namespace EmployeeManagement.Repository
{
    using EmployeeManagement.Model;
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SqlClient;

    /// <summary>
    ///  RepoEmployeeImplementation class
    /// </summary>
    /// <seealso cref="EmployeeManagement.Repository.IRepo" />
    public class RepoEmployeeImplementation : IRepo
    {
        string connectionString = "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = EmployeeManagement; Integrated Security = SSPI";
        public bool AddEmployee(Employee emp)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("spAddEmployee", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@FullName", emp.FullName);
            command.Parameters.AddWithValue("@Age", emp.Age);
            command.Parameters.AddWithValue("@EmailId", emp.EmailId);
            command.Parameters.AddWithValue("@WorkExp", emp.WorkExperience);

            var result = command.ExecuteNonQuery();
            if (result >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DeleteEmployee(int Id)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("spDeleteEmployee", connection);
            command.CommandType = CommandType.StoredProcedure;
            Employee emp = new Employee();

            command.Parameters.AddWithValue("@Id", emp.Id);

            var result = command.ExecuteNonQuery();
            if (result >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Employee> GetAllEmployee()
        {
            SqlConnection Connection = new SqlConnection(connectionString);
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

        public bool UpdateEmployee(Employee emp)
        {
            SqlConnection Connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@Id", emp.Id);
            command.Parameters.AddWithValue("@FullName", emp.FullName);
            command.Parameters.AddWithValue("@Age", emp.Age);
            command.Parameters.AddWithValue("@EmailId", emp.EmailId);
            command.Parameters.AddWithValue("@WorkExp", emp.WorkExperience);

            var result = command.ExecuteNonQuery();
            if (result >= 1)
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
