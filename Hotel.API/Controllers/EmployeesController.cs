using AutoMapper;
using Hotel.API.Models;
using Hotel.Core;
using Hotel.Core.DTOs;
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
        private readonly IMapper _mapper;
        public EmployeesController(IEmployeeService employeeService,IMapper mapper)
        {
            _employeeService = employeeService;
            _mapper = mapper;   
        }
    
        // GET: api/<UsersController>
        [HttpGet]
        public ActionResult Get()
        {
           var list= _employeeService.GetAll();
           var listDto = _mapper.Map<IEnumerable<EmployeeDto>>(list);
            
            return Ok(listDto);
        }

        // GET api/<UsersController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var employee=_employeeService.Get(id);
            var Employeedto = _mapper.Map<EmployeeDto>(employee);
            return Ok(Employeedto);
        }

        // POST api/<UsersController>
        [HttpPost]
        public Employee Post([FromBody] EmployeePostModel value)
        {
            var employeeToAdd = new Employee {Name=value.Name,Age=value.Age,Hours=value.Hours };  
            return _employeeService.Add(employeeToAdd); 
        }

        // PUT api/<UsersController>/5
        [HttpPut("{id}")]
        public Employee Put(int id, [FromBody] EmployeePostModel value)
        {
            var employeeToAdd = new Employee { Name = value.Name, Age = value.Age, Hours = value.Hours };
            return _employeeService.Update(employeeToAdd, id);
        }

        // DELETE api/<UsersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _employeeService.Delete(id);    
        }
    }
}
