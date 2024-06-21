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
        
        public Staff GetStaffByUsernameAndpassword(string username, string hashedPassword)
        {
            string query = "SELECT StaffID, Username, Role, PasswordHash FROM Staff WHERE Username = @username AND PasswordHash = @PasswordHash";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@Username", SqlDbType.NVarChar) { Value = username }, //Case incencitivyvy, might change evrything to lower also queary
                new SqlParameter("@PasswordHash", SqlDbType.NVarChar) { Value = hashedPassword }
            };
            DataTable dataTable = ExecuteSelectQuery(query, sqlParameters);

            return ReadStaff(dataTable);
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

        public Staff GetStaffByUsername(string username)
        {
            if (string.IsNullOrEmpty(username))
            {
                throw new ArgumentException("Username cannot be null or empty.", nameof(username));
            }

            string query = "SELECT StaffID, Username, Role, PasswordHash FROM Staff WHERE Username = @Username";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
        new SqlParameter("@Username", SqlDbType.NVarChar) { Value = username }
            };
            DataTable dataTable = ExecuteSelectQuery(query, sqlParameters);

            if (dataTable.Rows.Count > 0)
            {
                return ReadStaff(dataTable);
            }
            else
            {
                return null;
            }
        }
    }
}