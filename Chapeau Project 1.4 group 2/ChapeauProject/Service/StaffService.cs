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

        private bool VerifyPassword(string password, string storedHash)
        {
            string hashedPasswordInput = HashPassword(password);
            return storedHash == hashedPasswordInput;
        }

        public Staff CheckLoginCredentials(string username, string password)
        {
            Staff staff = GetStaffByUsername(username);
            if (staff != null)
            {
                bool isPasswordCorrect = VerifyPassword(password, staff.PasswordHash);
                if (isPasswordCorrect)
                {
                    return staff;
                }
            }
            return null;
        }

        private string HashPassword(string password)
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
