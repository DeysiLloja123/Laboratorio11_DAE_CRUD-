using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System.Collections.Generic;

namespace Laboratorio11.Models
{
    public class SchoolContext:DbContext

    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAB1504-25\\SQLEXPRESS;"+
                "Initial Catalog=semana11; ; trustservercertificate=True;User Id=UserTecsup;Password=UserTecsup");
        }

    }
    
}
