using System;
using System.Collections.Generic;

public class Customer
{
    static List<Customer> customerlist = new List<Customer>();

    public string name { get; set; }
    public long mobile { get; set; }
    public string city { get; set; }
    public int pincode { get; set; }
    public string username { get; set; }
    public string password { get; set; }

    // Register
    public void Register()
    {
        Customer c = new Customer();

        Console.WriteLine("***** Registration Here *****");

        Console.Write("Enter Name : ");
        c.name = Console.ReadLine();

        Console.Write("Enter Mobile Number : ");
        c.mobile = Convert.ToInt64(Console.ReadLine());

        foreach (Customer cus in customerlist)
        {
            if (cus.mobile == c.mobile)
            {
                Console.WriteLine("Mobile Number Already Exists.");
                return;
            }
        }

        Console.Write("Enter City : ");
        c.city = Console.ReadLine();

        Console.Write("Enter Pincode : ");
        c.pincode = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Username : ");
        c.username = Console.ReadLine();

        foreach (Customer cus in customerlist)
        {
            if (cus.username == c.username)
            {
                Console.WriteLine("Username Already Exists.");
                return;
            }
        }

        Console.Write("Enter Password : ");
        c.password = Console.ReadLine();

        customerlist.Add(c);

        Console.WriteLine("Registration Successful.");
    }

    // Login
    public bool Login()
    {
        Console.Write("Enter Username : ");
        string u_name = Console.ReadLine();

        Console.Write("Enter Password : ");
        string u_password = Console.ReadLine();

        foreach (Customer cus in customerlist)
        {
            if (cus.username == u_name && cus.password == u_password)
            {
                Console.WriteLine("Welcome " + cus.name);
                return true;
            }
        }

        Console.WriteLine("Invalid Username or Password.");
        return false;
    }

    // Customer Menu
   public void CustomerMenu()
{
    ProductManager pm = new ProductManager();
    CartManager cm = new CartManager();
    Payment payment = new Payment();
    OrderManager om = new OrderManager();

    int choice;

    do
    {
        Console.WriteLine("\n===== CUSTOMER MENU =====");
        Console.WriteLine("1. View Products");
        Console.WriteLine("2. Add To Cart");
        Console.WriteLine("3. Remove Item");
        Console.WriteLine("4. Update Quantity");
        Console.WriteLine("5. View Cart");
        Console.WriteLine("6. View Total");
        Console.WriteLine("7. Apply Coupon");
        Console.WriteLine("8. Payment");
        Console.WriteLine("9. View Previous Orders");
        Console.WriteLine("10. Search Order");
        Console.WriteLine("11. Cancel Order");
        Console.WriteLine("12. Download Invoice");
        Console.WriteLine("13. Update Profile");
        Console.WriteLine("14. Change Password");
        Console.WriteLine("15. Logout");

        Console.Write("Enter Choice : ");
        choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                pm.ViewAllProducts();
                break;

            case 2:
                cm.AddToCart();
                break;

            case 3:
                cm.RemoveItem();
                break;

            case 4:
                cm.UpdateQuantity();
                break;

            case 5:
                cm.ViewCart();
                break;

            case 6:
                cm.ViewTotal();
                break;

            case 7:
                cm.ApplyCoupon();
                break;

            case 8:
                payment.Pay();
                break;

            case 9:
                om.ViewOrders();
                break;

            case 10:
                om.SearchOrder();
                break;

            case 11:
                om.CancelOrder();
                break;

            case 12:
                om.DownloadInvoice();
                break;

            case 13:
                UpdateProfile();
                break;

            case 14:
                ChangePassword();
                break;

            case 15:
                Logout();
                break;

            default:
                Console.WriteLine("Invalid Choice.");
                break;
        }

    } while (choice != 15);
}
    // Update Profile
    public void UpdateProfile()
    {
        Console.Write("Enter Username : ");
        string uname = Console.ReadLine();

        foreach (Customer cus in customerlist)
        {
            if (cus.username == uname)
            {
                Console.Write("Enter New Name : ");
                cus.name = Console.ReadLine();

                Console.Write("Enter New Mobile : ");
                cus.mobile = Convert.ToInt64(Console.ReadLine());

                Console.Write("Enter New City : ");
                cus.city = Console.ReadLine();

                Console.Write("Enter New Pincode : ");
                cus.pincode = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Profile Updated Successfully.");
                return;
            }
        }

        Console.WriteLine("User Not Found.");
    }

    // Change Password
    public void ChangePassword()
    {
        Console.Write("Enter Username : ");
        string uname = Console.ReadLine();

        Console.Write("Enter Old Password : ");
        string oldPass = Console.ReadLine();

        foreach (Customer cus in customerlist)
        {
            if (cus.username == uname && cus.password == oldPass)
            {
                Console.Write("Enter New Password : ");
                cus.password = Console.ReadLine();

                Console.WriteLine("Password Changed Successfully.");
                return;
            }
        }

        Console.WriteLine("Invalid Username or Password.");
    }

    // Logout
    public void Logout()
    {
        Console.WriteLine("Logout Successfully.");
    }
}