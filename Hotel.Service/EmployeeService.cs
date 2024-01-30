using Hotel.Core.Entities;
using Hotel.Core.Repositories;
using Hotel.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Service
{
    public class EmployeeService: IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;
        
        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;   
        }
        
        public List<Employee> GetAll() 
        {
            return _employeeRepository.GetAllEmployees();
        }
        public Employee Get(int id) 
        { 
            return _employeeRepository.GetEmployeeById(id);
        }
        public Employee Update(Employee employee,int id)
        {
            return _employeeRepository.Update(id, employee);
        }
        public void Delete(int id) 
        { 
            _employeeRepository.Delete(id); 
        }
        public Employee Add(Employee employee)
        {
            return _employeeRepository.Add(employee);   
        }
    }
}
