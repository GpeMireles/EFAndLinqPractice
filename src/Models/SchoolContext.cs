using Microsoft.EntityFrameworkCore;

namespace EFAndLinqPractice_SchoolAPI.Models
{
    public class SchoolContext : DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        {
            
        }
    }
}