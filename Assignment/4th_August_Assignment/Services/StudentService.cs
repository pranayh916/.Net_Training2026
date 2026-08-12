using _4_august_practice.Data;
using _4_august_practice.Models;
using _4_august_practice.Repository;
using Microsoft.EntityFrameworkCore;

namespace _4_august_practice.Services
{
    public class StudentService : IStudentService
    {
        private readonly AppDBContext _context;

        public StudentService(AppDBContext context)
        {
            _context = context;
        }

        public List<Student> GetAllStudents()
        {
            return _context.Students.ToList();
        }

        public Student GetStudentById(int id)
        {
            return _context.Students.FirstOrDefault(s => s.Id == id);
        }

        public void AddStudent(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
        }

        public void UpdateStudent(Student student)
        {
            _context.Students.Update(student);
            _context.SaveChanges();
        }

        public void DeleteStudent(int id)
        {
            var student = _context.Students.FirstOrDefault(s => s.Id == id);

            if (student != null)
            {
                _context.Students.Remove(student);
                _context.SaveChanges();
            }
        }
    }
}