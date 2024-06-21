using System;
using System.Collections.Generic;
using Model;
using DAL;
using System.Text;
using System.Security.Cryptography;
using static System.Collections.Specialized.BitVector32;


namespace Service
{
    public class StaffService
    {
        private readonly StaffDAL _staffDAL;

        public StaffService()
        {
            _staffDAL = new StaffDAL();
        }

        public string LoggedUser {  get; private set; }

        public Staff GetStaffByUsernameAndpassword(string username, string password)
        {
            var hashedPassword = HashPassword(password);
            LoggedUser = username;
            return _staffDAL.GetStaffByUsernameAndpassword(username, hashedPassword);
        }

        public int GetLoggedEmployeeId()
        {
            Staff staff = _staffDAL.GetStaffByUsername(LoggedUser);
            if (staff != null)
            {
                return staff.StaffID;
            }
            else
            {
                throw new Exception("No staff member is currently logged in.");
            }
        }

        public Staff CheckLoginCredentials(string username, string password)
        {
            Staff staff = _staffDAL.GetStaffByUsernameAndpassword(username, password);
            if (staff != null)
            {
                string hashedPassword = HashPassword(password);
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