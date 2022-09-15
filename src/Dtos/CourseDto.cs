
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EFAndLinqPractice_SchoolAPI.Models
{
    public class CourseDto {
        public int Id { get; set; }

        public string Name { get; set; }
        public List<Student> Students { get; set; } = new List<Student>();
    }
}