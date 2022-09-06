using EFAndLinqPractice_SchoolAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace EFAndLinqPractice_SchoolAPI.Services
{
    public class StudentService : IStudentService
    {
        private readonly SchoolContext _dbContext;

        public StudentService(SchoolContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Student Create(Student student)
        {
            _dbContext.Add(student);
            _dbContext.SaveChanges();
            return student;
        }

        public Student GetById(int id)
        {
            var student = _dbContext.Students.SingleOrDefault(a => a.Id == id);
            return student;
        }

        public IEnumerable<Student> GetAll()
        {
            var students = _dbContext.Students.ToList();
            return students;
        }

        public IEnumerable<Student> GetStudentsByCourseId(int courseId)
        {
            var students = from student in _dbContext.Students
                           where student.Courses.Any(a => a.Id == courseId)
                           select student;
            
            //var students = _dbContext.Students.Where(a => a.Courses.Any(b => b.Id == courseId));
            return students;

        }

        public void DeleteById(int id)
        {
            _dbContext.Students.Remove(_dbContext.Students.Find(id));
            _dbContext.SaveChanges();
        }
    }
}