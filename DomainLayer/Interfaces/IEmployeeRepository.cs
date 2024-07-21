using DomainLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Interfaces
{
    public interface IEmployeeRepository
    {
        void CreateNewEmployee(Employee employee);

        Employee GetEmployeeProfile(int employeeId);
    }
}
