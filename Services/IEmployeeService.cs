using System.Collections.Generic;
using asp.Models;

namespace asp.Services
{
    public interface IEmployeeService

    {
        IEnumerable<Employee> GetAll();
        Employee getEmployeetById(int id);
        void Create(Employee employee);
        void Update(Employee employee);
        void Delete(int id);
     

    }
}