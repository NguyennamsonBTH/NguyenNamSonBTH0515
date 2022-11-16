using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NguyenNamSonBTH515.Models;

namespace NguyenNamSonBTH515.Data
{
    public class ApplicationDbcontext:DbContext
    {
        public ApplicationDbcontext (DbContextOptions<ApplicationDbcontext> options):base(options)
        {
        }
        public DbSet<NguyenNamSonBTH515.Models.Faculty> Faculty {get; set;} =default!;
        public DbSet<NguyenNamSonBTH515.Models.Student> Student {get; set;} = default!;
        public DbSet<NguyenNamSonBTH515.Models.Customer>? Customer { get; set; }
        public DbSet<NguyenNamSonBTH515.Models.Person>? Person { get; set; }
        public DbSet<NguyenNamSonBTH515.Models.Employee>? Employee { get; set; }
    }
}
