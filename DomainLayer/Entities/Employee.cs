using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Entities
{
    public class Employee
    {
        public int Id { get; set; }

        public int EmployeeId { get; set; }

        public string EmployeeName { get; set; }

        public string JobTitle { get; set;}

        public string Manager { get; set; }

        public string Department { get; set; }
   
    }
}
