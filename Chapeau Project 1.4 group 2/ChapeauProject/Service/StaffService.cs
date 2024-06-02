using System;
using System.Collections.Generic;
using Model;
using DAL;
using System.Text;
using System.Security.Cryptography;


namespace Service
{
    public class StaffService
    {
        private readonly StaffDAL _staffDAL;

        public StaffService()
        {
            _staffDAL = new StaffDAL();
        }

        

        public Staff GetStaffByUsername(string username)
        {
            var staffList = _staffDAL.GetAllStaff();
            foreach (var staff in staffList)
            {
                if (staff.Username.Equals(username, StringComparison.OrdinalIgnoreCase))
                {
                    return staff;
                }
            }
            return null;
        }

        public bool ValidateStaffCredentials(string username, string password)
        {
            string hashedPassword = HashPassword(password);
            return _staffDAL.ValidatePassword(username, hashedPassword);
        }



        public string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}
