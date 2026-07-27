using System;

class Program
{
    static void Main()
    {
        Customer customer = new Customer();
        Admin admin = new Admin();

        int choice;

        do
        {
            Console.WriteLine("\n===== SHOP EASE =====");
            Console.WriteLine("1. Customer Register");
            Console.WriteLine("2. Customer Login");
            Console.WriteLine("3. Admin Login");
            Console.WriteLine("4. Exit");
            Console.Write("Enter Choice : ");

            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    customer.Register();
                    break;

                case 2:
            {
             bool result = customer.Login();

             if (result)
            {
                 customer.CustomerMenu();
            }

             break;
            }

             case 3:
                   bool done= admin.Login();
                    if (done == true)
                    {
                        admin.AdminMenu();
                    }
                    break;

             case 4:
                    Console.WriteLine("Thank You");
                    break;

                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }

        } while (choice != 4);
    }
}