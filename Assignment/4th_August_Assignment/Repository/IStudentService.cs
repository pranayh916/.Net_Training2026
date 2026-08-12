using _4_august_practice.Models;

namespace _4_august_practice.Repository
{
    public interface IStudentService
    {
        List<Student> GetAllStudents();
        Student? GetStudentById(int id);
        void AddStudent(Student student);
        void UpdateStudent(Student student);
        void DeleteStudent(int id);
    }
}