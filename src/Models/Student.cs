
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFAndLinqPractice_SchoolAPI.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        public DateTime Birthday { get; set; }

        [Required]
        [Column(TypeName = "decimal(3,2)")]
        public decimal Height { get; set; }
        public List<Course> Courses { get; set; } = new List<Course>();
    }
}