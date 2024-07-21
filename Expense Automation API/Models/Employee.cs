namespace Expense_Automation_API.Models
{
    public class Employee
    { 
        public int? Id = null;

        public int? EmployeeId = null;

        public string EmployeeName { get; set; }

        public string JobTitle { get; set;}

        public string Manager { get; set; }

        public string Department { get; set; }
   
    }
}
