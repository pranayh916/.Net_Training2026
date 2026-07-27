using System;

public class Admin
{
    private string username = "admin";
    private string password = "admin123";

    public bool Login()
    {
        Console.Write("Enter Username : ");
        string uname = Console.ReadLine();

        Console.Write("Enter Password : ");
        string pass = Console.ReadLine();

        if (uname == username && pass == password)
        {
            Console.WriteLine("Login Successful.");
            return true;
        }

        Console.WriteLine("Invalid Username or Password.");
        return false;
    }

    public void AdminMenu()
    {
        ProductManager pm = new ProductManager();
        CategoryManager cm = new CategoryManager();
        int choice;

        do
        {
            Console.WriteLine("\n===== ADMIN MENU =====");
            Console.WriteLine("1. Add Product");
            Console.WriteLine("2. Update Product");
            Console.WriteLine("3. Delete Product");
            Console.WriteLine("4. Search Product");
            Console.WriteLine("5. View All Products");
            Console.WriteLine("6. Add Category");
            Console.WriteLine("7. Update Category");
            Console.WriteLine("8. Delete Category");
            Console.WriteLine("10. Logout");
            Console.Write("Enter Choice : ");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    pm.AddProduct();
                    break;

                case 2:
                    pm.UpdateProduct();
                    break;

                case 3:
                    pm.DeleteProduct();
                    break;

                case 4:
                    pm.SearchProduct();
                    break;

                case 5:
                    pm.ViewAllProducts();
                    break;

                case 6:
    cm.AddCategory();
    break;
    case 7:
    cm.UpdateCategory();
    break;

    case 8:
    cm.DeleteCategory();
    break;

          case 9:
    cm.ViewCategory();
    break;

          case 10:
    Console.WriteLine("Logout Successfully.");
    break;
            }

        } while (choice != 6);
    }
}