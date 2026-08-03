using _2nd_August_Practice.Models;

namespace _2nd_August_Practice.Repository
{
    public class CourseService : ICourseService
    {
        private List<Course> courses = new List<Course>()
        {
            new Course
            {
                Id = 1,
                CourseName = "ASP.NET Core",
                Department = "Computer",
                Fees = 25000
            },
            new Course
            {
                Id = 2,
                CourseName = "Java Full Stack",
                Department = "IT",
                Fees = 30000
            },
            new Course
            {
                Id = 3,
                CourseName = "Python",
                Department = "AI",
                Fees = 20000
            }
        };

        public List<Course> GetAll()
        {
            return courses;
        }

        public Course? GetCourse(int id)
        {
            return courses.FirstOrDefault(c => c.Id == id);
        }

        public void AddCourse(Course course)
        {
            courses.Add(course);
        }

        public void UpdateCourse(Course course)
        {
            var existing = courses.FirstOrDefault(c => c.Id == course.Id);

            if (existing != null)
            {
                existing.CourseName = course.CourseName;
                existing.Department = course.Department;
                existing.Fees = course.Fees;
            }
        }

        public void DeleteCourse(int id)
        {
            var course = courses.FirstOrDefault(c => c.Id == id);

            if (course != null)
            {
                courses.Remove(course);
            }
        }
    }
}