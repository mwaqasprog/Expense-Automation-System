namespace Expense_Automation_API.Controllers
{
    using ApplicationLayer.ServiceInterfaces;
    using Expense_Automation_API.Configurations;
    using Expense_Automation_API.Models;
    using Microsoft.AspNetCore.Mvc;

    /// <summary>
    /// Defines the <see cref="EmployeeController" />
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {

        private readonly IEmployeeService _employeeService;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeController"/> class.
        /// </summary>
        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        /// <summary>
        /// The CreateProfile
        /// </summary>
        /// <param name="employee">The employee<see cref="Employee"/></param>
        /// <returns>The <see cref="Employee"/></returns>
        [HttpPost]
        public IActionResult CreateProfile([FromBody] Employee employee)
        {
            _employeeService.CreateProfile(Mapper.MapEmployeeObject(employee));
            return Ok(new { Message = "Customer created successfully" });
        }

        /// <summary>
        /// The GetAllEmployees
        /// </summary>
        /// <returns>The <see cref="IEnumerable{Employee}"/></returns>
        [HttpGet]
        public IEnumerable<Employee> GetAllEmployees()
        {
            return null;
        }

        /// <summary>
        /// The GetEmployeeProfile
        /// </summary>
        /// <returns>The <see cref="Employee"/></returns>
        [HttpGet]
        public Employee GetEmployeeProfile([FromQuery] int employeeId)
        {
            return null;
        }
    }
}
