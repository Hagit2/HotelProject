using Hotel.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Core.Services
{
    public interface IEmployeeService
    {
        List<Employee> GetAll();
        Employee Get(int id);
        Employee Update(Employee employee, int id);
        void Delete(int id);
        Employee Add(Employee employee);


    }
}
