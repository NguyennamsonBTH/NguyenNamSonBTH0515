using System.ComponentModel.DataAnnotations;
using System.Data;
namespace NguyenNamSonBTH515.Models
{
    public class Faculty
    {
        [Key]
        public string FacultyID { get; set; }

        public string FacultyName { get; set; }
    }
}