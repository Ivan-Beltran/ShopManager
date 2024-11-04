using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer.Entities
{
    public class Employees
    {
        public int EmployeeId { get; set; }
        public string Names { get; set; }
        public string LastNames { get; set; }
        public string UserEmployee { get; set; }
        public string PasswordEmployee { get; set; }
        public string DUI { get; set; }
        public string Email { get; set; }

        public int RoleId { get; set; }
    }
}
