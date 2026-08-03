using _2nd_August_Practice.Models;

namespace _2nd_August_Practice.Repository
{
    public interface IStudentService
    {
        List<Student> GetAll();

        Student? GetStudent(int id);

        void AddStudent(Student student);

        void UpdateStudent(Student student);

        void DeleteStudent(int id);
    }
}