using Hotel.Core.Entities;
using Hotel.Core.Services;


using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Hotel.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeService _employeeService; 
        public EmployeesController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }
    
        // GET: api/<UsersController>
        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            return _employeeService.GetAll();
        }

        // GET api/<UsersController>/5
        [HttpGet("{id}")]
        public Employee Get(int id)
        {
            return _employeeService.Get(id);
        }

        // POST api/<UsersController>
        [HttpPost]
        public Employee Post([FromBody] Employee value)
        {
            return _employeeService.Add(value); 
        }

        // PUT api/<UsersController>/5
        [HttpPut("{id}")]
        public Employee Put(int id, [FromBody] Employee value)
        {
            return _employeeService.Update(value,id);
        }

        // DELETE api/<UsersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _employeeService.Delete(id);    
        }
    }
}
