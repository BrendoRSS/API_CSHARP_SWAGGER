using Microsoft.AspNetCore.Mvc;
using PrimeiraAPI.infraEstrutura;
using PrimeiraAPI.Model;
using PrimeiraAPI.View;

namespace PrimeiraAPI.Controllers
{
    [ApiController]
    [Route("api/v1/employee")]
    public class EmployeeController : ControllerBase
    {
        private readonly iEmployeeRepository _employeeRepository;

        public EmployeeController(iEmployeeRepository employeeRepoitory)
        {
            _employeeRepository = employeeRepoitory ?? throw new ArgumentNullException(nameof(employeeRepoitory));
        }

        [HttpPost]
        public IActionResult Add(EmployeeViewModel employeeView)
        {
            var employee = new Employee(employeeView.Nome, employeeView.Idade, null);

            _employeeRepository.Add(employee);


            return Ok();
        }

        [HttpGet]
        public IActionResult Get()
        {
            var employess = _employeeRepository.Get();
            return Ok(employess);
        }
    }
}
