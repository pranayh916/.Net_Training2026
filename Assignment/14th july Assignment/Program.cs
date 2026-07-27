using System;

public class Program
{
    string name;
    string password;

    // Login Validation
    public bool ValidateUser()
    {
        return (name == "admin" && password == "123");
    }

    // Stationery Menu
    public void StationeryMenu()
    {
        Stationery s = new Stationery();

        while (true)
        {
            Console.WriteLine("\n===== STATIONERY MENU =====");
            Console.WriteLine("1. Add Stationery Item");
            Console.WriteLine("2. Display All Items");
            Console.WriteLine("3. Search Item");
            Console.WriteLine("4. Update Item");
            Console.WriteLine("5. Delete Item");
            Console.WriteLine("6. Purchase Item");
            Console.WriteLine("7. View Low Stock Item");
            Console.WriteLine("8. Sort Item");
            Console.WriteLine("9. Exit");

            Console.Write("Enter Your Choice : ");
            int ch = Convert.ToInt32(Console.ReadLine());

            try
            {
                switch (ch)
                {
                    case 1:
                        s.AddItem();
                        break;

                    case 2:
                        s.DisplayItem();
                        break;

                    case 3:
                        s.SearchItem();
                        break;

                    case 4:
                        // s.UpdateItem();
                        Console.WriteLine("Update Item - Pending");
                        break;

                    case 5:
                        s.DeleteItem();
                        break;

                    case 6:
                        // s.PurchaseItem();
                        Console.WriteLine("Purchase Item - Pending");
                        break;

                    case 7:
                        // s.LowStockItem();
                        Console.WriteLine("Low Stock Item - Pending");
                        break;

                    case 8:
                        // s.SortItem();
                        Console.WriteLine("Sort Item - Pending");
                        break;

                    case 9:
                        Console.WriteLine("Thank You...");
                        return;

                    default:
                        Console.WriteLine("Invalid Choice.");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

    // Main Method
    static void Main()
    {
        int attempt = 1;

        while (attempt <= 3)
        {
            Program p = new Program();

            Console.WriteLine("\n===== CUSTOMER LOGIN =====");

            Console.Write("Enter Username : ");
            p.name = Console.ReadLine();

            Console.Write("Enter Password : ");
            p.password = Console.ReadLine();

            if (p.ValidateUser())
            {
                Console.WriteLine("\nWelcome " + p.name);
                p.StationeryMenu();
                return;
            }
            else
            {
                Console.WriteLine("\nInvalid Username or Password.");

                if (attempt < 3)
                {
                    Console.WriteLine("Remaining Attempts : " + (3 - attempt));
                }
            }

            attempt++;
        }

        Console.WriteLine("\nAccount Locked.");
    }
}