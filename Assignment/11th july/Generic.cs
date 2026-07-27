// using System;

// static class Generic
// {
//     public static string ProperCase(this string name)
//     {
//         return char.ToUpper(name[0]) + name.Substring(1).ToLower();
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         string name = "Pranay";

//         Console.WriteLine(name.ProperCase());
//     }
// }

// using System;
// using System.Threading.Tasks;

// class AsyncAwaitDemo
// {
//     static async Task Main()
//     {
//         Console.WriteLine("Loading Employee Data...");

//         await LoadEmployee();

//         Console.WriteLine("Completed Successfully.");
//     }

//     static async Task LoadEmployee()
//     {
//         Console.WriteLine("Please wait...");

//         await Task.Delay(3000);

//         Console.WriteLine("Employee Data Loaded.");
//     }
// }   

using System.IO;
using System;

class Gneric
{
    static void Main()
    {
            File.WriteAllText("emp.txt","Name: Rahul");
            String s=File.ReadAllText("emp.txt");
            Console.WriteLine(s);

    }
}
