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
        }

        public Employee GetEmployeetById(int ID)
        {
            var employee = _context.Employees.FirstOrDefault(e => e.ID == ID);
            return employee;
        }

        public void Create(Employee employee)
        {
             _context.Employees.Add(employee);
             _context.SaveChanges();
        }

        public void Update(Employee employee)
        {
            _context.Employees.Update(employee);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var employee = GetEmployeetById(id);
            _context.Employees.Remove(employee);
            _context.SaveChanges();
        }

        public IEnumerable<Employee> Search(string searchString)
        {
            

            throw new System.NotImplementedException();
        }

        
        
    }
}