namespace _16th__july_assignment.Models
{
    public class Employee
    {
       public  int empid { get; set; }
        public string empname { get; set; } = "";
        public string empdepartment { set; get; } = "";
        public double  empsalary { set; get; }
        public required string empemail { set; get; } = "";

    }
}
