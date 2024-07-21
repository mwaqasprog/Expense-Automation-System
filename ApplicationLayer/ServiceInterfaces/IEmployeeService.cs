using ApplicationLayer.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.ServiceInterfaces
{
    public interface IEmployeeService
    {
        void CreateProfile(EmployeeDTO employeeDTO);
    }
}
