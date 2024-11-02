using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer.InputEntities
{
    public class EmployeesInput
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
        public int DUI { get; set; }
        public string Email { get; set; }

        public int RoleId { get; set; }

    }
}
