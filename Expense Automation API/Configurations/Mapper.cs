using ApplicationLayer.DataTransferObjects;
using Expense_Automation_API.Models;

namespace Expense_Automation_API.Configurations
{
    public static class Mapper
    {
        public static EmployeeDTO MapEmployeeObject(Employee employee)
        {
            return new EmployeeDTO(employee.EmployeeName, employee.JobTitle, employee.Manager, employee.Department);
        }
    }
}
