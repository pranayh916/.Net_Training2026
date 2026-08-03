using _2nd_August_Practice.Models;

namespace _2nd_August_Practice.Repository
{
    public class StudentService : IStudentService
    {
        private List<Student> students = new List<Student>()
        {
            new Student
            {
                Id = 1,
                Name = "Pranay",
                Age = 21,
                Course = "Computer Engineering",
                Email = "pranay@gmail.com"
            },
            new Student
            {
                Id = 2,
                Name = "Rahul",
                Age = 22,
                Course = "Information Technology",
                Email = "rahul@gmail.com"
            },
            new Student
            {
                Id = 3,
                Name = "Sneha",
                Age = 20,
                Course = "Computer Science",
                Email = "sneha@gmail.com"
            }
        };

        public List<Student> GetAll()
        {
            return students;
        }

        public Student? GetStudent(int id)
        {
            return students.FirstOrDefault(s => s.Id == id);
        }

        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public void UpdateStudent(Student student)
        {
            var existing = students.FirstOrDefault(s => s.Id == student.Id);

            if (existing != null)
            {
                existing.Name = student.Name;
                existing.Age = student.Age;
                existing.Course = student.Course;
                existing.Email = student.Email;
            }
        }

        public void DeleteStudent(int id)
        {
            var student = students.FirstOrDefault(s => s.Id == id);

            if (student != null)
            {
                students.Remove(student);
            }
        }
    }
}