using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using MvcEmployees.Utilities;
namespace MvcEmployees.Models
{
    public enum GenderType { Male, Female, Others };

    public class Employee
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public GenderType Gender { get; set; }

        public string State { get; set; }

        public string City { get; set; }

        public string Pincode { get; set; }

        public Employee() { }

        public Employee(string id, string name, GenderType gender, string state, string city, string pincode)
        {
            Id = id;
            Name = name;
            Gender = gender;
            State = state;
            City = city;
            Pincode = pincode;
        }

        public Employee(EmployeeDetailsViewModel employee)
        {
            Id = employee.Id;
            Name = employee.Name;
            Gender = employee.Gender;
            State = employee.State;
            City = employee.City;
            Pincode = employee.Pincode;
        }

        public static void Add(Employee employee)
        {
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = ConfigurationManager.ConnectionStrings["employeedb"].ConnectionString;
                SqlCommand command = new SqlCommand();
                command.CommandText = "INSERT INTO Employee VALUES(@id,@name,@gender,@state,@city,@pincode)";
                command.Connection = connection;
                command.Parameters.AddWithValue("@id", employee.Id);
                command.Parameters.AddWithValue("@name", employee.Name);
                command.Parameters.AddWithValue("@gender", employee.Gender.ToString());
                command.Parameters.AddWithValue("@state", employee.State);
                command.Parameters.AddWithValue("@city", employee.City);
                command.Parameters.AddWithValue("@pincode", employee.Pincode);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public static Employee GetEmployee(string id)
        {
            using (SqlConnection connection = new SqlConnection())
            {
                Employee employee=new Employee();
                connection.ConnectionString = ConfigurationManager.ConnectionStrings["employeedb"].ConnectionString;
                SqlCommand command = new SqlCommand();
                command.CommandText = "SELECT * FROM Employee";
                command.Connection = connection;
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    employee=new Employee(reader["Id"].ToString(), reader["Name"].ToString(), reader["Gender"].ToString().ToEnum<GenderType>(), reader["State"].ToString(), reader["City"].ToString(), reader["Pincode"].ToString());
                }
                return employee;
            }
        }

        public static List<EmployeeViewModel> GetEmployees()
        {
            List<EmployeeViewModel> employees = new List<EmployeeViewModel>();
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = ConfigurationManager.ConnectionStrings["employeedb"].ConnectionString;
                SqlCommand command = new SqlCommand();
                command.CommandText = "SELECT Id,Name FROM Employee";
                command.Connection = connection;               
                connection.Open();
                SqlDataReader reader= command.ExecuteReader();
                while (reader.Read())
                {
                    employees.Add(new EmployeeViewModel(reader["Id"].ToString(),reader["Name"].ToString()));
                }
                return employees;
            }
        }
    }

    class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }

    public class VisitCounter
    {
        public static int Counter { get; set; }
    }
}