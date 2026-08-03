using _2nd_August_Practice.Models;

namespace _2nd_August_Practice.Repository
{
    public interface ICourseService
    {
        List<Course> GetAll();
        Course? GetCourse(int id);
        void AddCourse(Course course);
        void UpdateCourse(Course course);
        void DeleteCourse(int id);
    }
}