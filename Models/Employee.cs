using System.ComponentModel.DataAnnotations;

namespace asp.Models
{
    public class Employee
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string PassWord {get;set;}
    }
}
