
using asp.Models;
using Microsoft.EntityFrameworkCore;

namespace Asp.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Movie> Movies {get;set;}
        public DbSet<Employee> Employees {get;set;} 
        
        

        
    }
}