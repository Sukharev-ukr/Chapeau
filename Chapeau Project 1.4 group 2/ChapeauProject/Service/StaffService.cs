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
        private readonly StaffDao _staffDAL;

        public StaffService()
        {
            _staffDAL = new StaffDao();
        }



        public Staff GetStaffByUsernameAndpassword(string username, string password)
        {
            var hashedPassword = HashPassword(password);
            return _staffDAL.GetStaffByUsernameAndpassword(username, hashedPassword);
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