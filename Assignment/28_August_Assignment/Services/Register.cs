using _28_July_Assignment.Models;

namespace _28_July_Assignment.Services
{
    public class Register : IRegister
    {
        private static List<Course> courses = new List<Course>()
        {
            new Course { Id = 100, Title = "DSGT", Credits = 2, Duration = 1 },
            new Course { Id = 101, Title = "OOP", Credits = 1, Duration = 1 },
            new Course { Id = 102, Title = "ADE", Credits = 2, Duration = 5 },
            new Course { Id = 103, Title = "DE", Credits = 2, Duration = 2 }
        };

        public List<Course> DisplayCourse()
        {
            return courses;
        }

        public Course RegisterCourse(Course course)
        {
            courses.Add(course);
            return course;
        }

        public Course? UpdateCourse(int id, Course course)
        {
            var existing = courses.FirstOrDefault(c => c.Id == id);

            if (existing == null)
                return null;

            existing.Title = course.Title;
            existing.Credits = course.Credits;
            existing.Duration = course.Duration;

            return existing;
        }

        public bool CancelCourse(int id)
        {
            var existing = courses.FirstOrDefault(c => c.Id == id);

            if (existing == null)
                return false;

            courses.Remove(existing);
            return true;
        }
    }
}