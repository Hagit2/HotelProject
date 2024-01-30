using Hotel.Core.Entities;
using Hotel.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Data.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly DataContexst _context;
        public EmployeeRepository(DataContexst context)
        { 
            _context = context;
        }

        public Employee Add(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
            return employee;
        }

        public void Delete(int id)
        {
            var employee=GetEmployeeById(id);   
            _context.Employees.Remove(employee);
            _context.SaveChanges();
        }

        public List<Employee> GetAllEmployees()
        {
            return _context.Employees.ToList();
        }

        public Employee GetEmployeeById(int id)
        {
            return _context.Employees.Find(id);//לבדוק אם התחביר נכון
        }

        public Employee Update(int id, Employee employee)
        {
            var _employee= GetEmployeeById(id);  
            _employee.Name = employee.Name;
            _employee.Hours = employee.Hours;
            _employee.Age = employee.Age;   
            _context.SaveChanges();
            return _employee;   
        }
    }
}
