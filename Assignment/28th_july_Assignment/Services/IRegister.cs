using _28_July_Assignment.Models;

namespace _28_July_Assignment.Services
{
    public interface IRegister
    {
        List<Course> DisplayCourse();

        Course RegisterCourse(Course course);

        Course? UpdateCourse(int id, Course course);

        bool CancelCourse(int id);
    }
}