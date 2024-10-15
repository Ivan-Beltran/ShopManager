using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer.Entities
{
    public class EmployeeSesion
    {
        public int EmployeeId { get; set; }
        public string EmployeeNames { get; set; }
        public string EmployeeLastNames { get; set; }
        public string EmployeeUser { get; set; }
        public string EmployeePassword { get; set; }
        public string EmployeeDUI { get; set; }
        public string EmployeeEmail { get; set; }

        public int EmployeeRoleId { get; set; }
    }
}
