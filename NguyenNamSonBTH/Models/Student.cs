using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
namespace NguyenNamSonBTH515.Models
{
    public class Student
    {
        public string? ID {get; set;}
        public string? StudentID {get; set;}
        public string? StudentName {get; set;}
        public string? FacultyID {get; set; }
        [ForeignKey("FacultyID")]
        public string? Faculty {get; set; }
    }
}