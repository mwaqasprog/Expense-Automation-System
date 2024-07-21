using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.DataTransferObjects
{
    public class EmployeeDTO
    {
        public EmployeeDTO(string employeeName, string jobTitle, string manager, string department) 
        { 
            EmployeeName = employeeName;
            JobTitle = jobTitle;
            Manager = manager;
            Department = department;
        }
        public int? Id = null;

        public int? EmployeeId = null;

        public string EmployeeName { get; set; }

        public string JobTitle { get; set; }

        public string Manager { get; set; }

        public string Department { get; set; }
    }
}
