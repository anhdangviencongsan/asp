using System.ComponentModel.DataAnnotations;

namespace asp.Models
{
    public class Login
    {
        [Key]
       public int IdUser { get; set; }
       [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}")]

        public string Email { get; set; }
        public string  Password { get; set; }
        public string FullName {get;set;}
        
    }
}