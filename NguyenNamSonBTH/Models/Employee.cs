using System.ComponentModel.DataAnnotations;
using System.Data;
namespace NguyenNamSonBTH515.Models{
    public class Employee
    {
        [Key]
        public string? ID {get; set;}
        public string? Name {get; set;}
        public string? Address {get; set;}
        
    }
}