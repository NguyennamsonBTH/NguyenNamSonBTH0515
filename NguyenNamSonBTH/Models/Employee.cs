using System.ComponentModel.DataAnnotations;
using System.Data;
namespace NguyenNamSonBTH515.Models{
    public class Employee
    {
        [Key]
        public string? EmpID {get; set;}
        public string? EmpName {get; set;}
        public string? Address {get; set;}
        
    }
}