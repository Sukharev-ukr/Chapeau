using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public Role Role { get; private set; }
        public string Name { get; set; }
    }
}
