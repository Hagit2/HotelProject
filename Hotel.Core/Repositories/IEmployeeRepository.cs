using Hotel.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Core.Repositories
{
    public interface IEmployeeRepository
    {
       List<Employee>GetAllEmployees();
       Employee GetEmployeeById(int id);
       void Delete (int id);    
       Employee Add(Employee employee);    
       Employee Update(int id,Employee employee);
      
    }
}
