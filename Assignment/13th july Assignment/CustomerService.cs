using System;

namespace ShoppingManagementSystem
{
    class CustomerService
    {
        private Customer customer = new Customer();

        public void Register()
        {
            Console.WriteLine("===== CUSTOMER REGISTRATION =====");

            Console.Write("Enter Customer ID : ");
            customer.CustomerId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Name : ");
            customer.Name = Console.ReadLine();

            Console.Write("Enter Email : ");
            customer.Email = Console.ReadLine();

            Console.Write("Enter Password : ");
            customer.Password = Console.ReadLine();

            Console.WriteLine("\nRegistration Successful");
        }

        
        public bool Login()
        {
            Console.WriteLine("\n===== CUSTOMER LOGIN =====");

            int attempts = 3;

            while (attempts > 0)
            {
                Console.Write("Enter Email : ");
                string email = Console.ReadLine();

                Console.Write("Enter Password : ");
                string password = Console.ReadLine();

                if (email == customer.Email && password == customer.Password)
                {
                    Console.WriteLine("\nWelcome " + customer.Name);
                    return true;
                }

                attempts--;

                if (attempts > 0)
                {
                    Console.WriteLine("Invalid Email or Password.");
                    Console.WriteLine("Remaining Attempts : " + attempts);
                }
            }

            Console.WriteLine("\nAccount Locked");
            return false;
        }
// getter hai 

        public Customer GetCustomer()
        {
            return customer;
        }
    }
}