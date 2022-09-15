
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFAndLinqPractice_SchoolAPI.Dtos
{
    public class StudentDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime Birthday { get; set; }

        public decimal Height { get; set; }

        public float Weight { get; set; }
        public List<string> Courses { get; set; } = new List<string>();
    }
}