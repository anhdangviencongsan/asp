using System.Collections.Generic;
using System.Linq;
using asp.Models;
using Asp.Data;

namespace asp.Services
{
    public class EmployeeService :IEmployeeService
    {
        private readonly DataContext _context ;
        public EmployeeService(DataContext context)
        {
            _context = context;
        }
        public IEnumerable<Employee> GetAll()
        {
            return _context.Employees.ToList();
            throw new System.NotImplementedException();
        }

        public Employee getEmployeetById(int id)
        {
            var employee = _context.Employees.FirstOrDefault(e => e.ID == id);
            throw new System.NotImplementedException();
        }

        public void Create(Employee employee)
        {
             _context.Employees.Add(employee);
             _context.SaveChanges();
            throw new System.NotImplementedException();
        }

        public void Update(Employee employee)
        {
            _context.Employees.Update(employee);
            _context.SaveChanges();
            throw new System.NotImplementedException();
        }

        public void Delete(int id)
        {
            var employee = getEmployeetById(id);
            _context.Employees.Remove(employee);
            throw new System.NotImplementedException();
        }

        public IEnumerable<Employee> Search(string searchString)
        {
            

            throw new System.NotImplementedException();
        }

        
        
    }
}