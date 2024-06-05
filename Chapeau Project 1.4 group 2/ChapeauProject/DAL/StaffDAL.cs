﻿using System;
using System.Collections.Generic;
using System.Data;
using Model;
using System.Data.SqlClient;
using BCrypt.Net;
using System.Reflection.Metadata;
using System.Security.Cryptography;

namespace DAL
{
    public class StaffDAL : BaseDAL
    {
        // Retrieves all staff members from the database
        public List<Staff> GetAllStaff()
        {
            // SQL query to select staff information
            string query = "SELECT StaffID, Username, Role, PasswordHash FROM Staff";
            // Execute the query and get the result in a DataTable
            DataTable dataTable = ExecuteSelectQuery(query);

            // List to store Staff objects
            List<Staff> staffList = new List<Staff>();
            // Loop through each row in the DataTable
            foreach (DataRow dr in dataTable.Rows)
            {
                // Create a new Staff object and populate its properties
                Staff staff = new Staff
                {
                    StaffID = (int)dr["StaffID"],
                    Username = (string)dr["Username"],
                    Role = (Role)Enum.Parse(typeof(Role), (string)dr["Role"]),
                    PasswordHash = (string)dr["PasswordHash"]
                };
                // Add the Staff object to the list
                staffList.Add(staff);
            }
            // Return the list of Staff objects
            return staffList;
        }

        public Staff GetStaffByUsername(string username)
        {
            string query = "SELECT StaffID, Username, Role, PasswordHash FROM Staff WHERE Username = @username";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
            new SqlParameter("@username", username)
            };
            DataTable dataTable = ExecuteSelectQuery(query, sqlParameters);
            if (dataTable.Rows.Count == 0)
            {
                return null; // Username not found
            }
            return ReadStaff(dataTable);
        }



        // Validates the password for a given username
        public bool ValidatePassword(string username, string hashedPassword)
        {
            string query = "SELECT COUNT(*) FROM Staff WHERE Username = @Username AND PasswordHash = @PasswordHash";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@Username", SqlDbType.NVarChar) { Value = username.ToLower() }, //Case incencitivyvy, might change evrything to lower also queary
                new SqlParameter("@PasswordHash", SqlDbType.NVarChar) { Value = hashedPassword }
            };

            DataTable dataTable = ExecuteSelectQuery(query, sqlParameters);

            return dataTable.Rows.Count > 0 && (int)dataTable.Rows[0][0] > 0;
            
        }

        private Staff ReadStaff(DataTable data)
        {
            DataRow dataRow = data.Rows[0];
            Staff staff = new Staff
            {
                StaffID = (int)dataRow["StaffID"],
                Username = (string)dataRow["Username"],
                PasswordHash = (string)dataRow["PasswordHash"],
                Role = (Role)Enum.Parse(typeof(Role), (string)dataRow["Role"])
            };
            return staff;
        }

        // Hashes the provided password using SHA-256


        //get  employee by id&pass
    }
}
