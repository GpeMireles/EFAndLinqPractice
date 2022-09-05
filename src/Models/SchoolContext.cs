using Microsoft.EntityFrameworkCore;

namespace EFAndLinqPractice_SchoolAPI.Models
{
    public class SchoolContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
    }
}