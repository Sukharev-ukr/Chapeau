using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Staff
    {
        public int StaffID { get; set; }
        public string Username { get; set; }
        public Role Role { get; set; }
        public string PasswordHash { get; set; }
    }
}