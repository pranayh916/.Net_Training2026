using System;

namespace ShoppingManagementSystem
{


    //remaining hai thoda 
    class Program
    {
        static void Main(string[] args)
        {
            CustomerService customerService = new CustomerService();
            ProductService productService = new ProductService();
            CartService cartService = new CartService();

            Console.WriteLine("=====================================");
            Console.WriteLine("   SHOPPING MANAGEMENT SYSTEM");
            Console.WriteLine("=====================================\n");

            // Customer Registration
            customerService.Register();

            // Customer Login
            bool login = customerService.Login();

            if (login)
            {
                // Add Products
                productService.AddProducts();

                                           // Display Products
                Console.WriteLine("\n===== PRODUCT LIST =====");
                productService.DisplayProducts();

                                                  // Search Product
                Console.WriteLine("\n===== SEARCH PRODUCT =====");
                productService.SearchProduct();

                                        // Add To Cart
                Console.WriteLine("\n===== ADD TO CART =====");
                cartService.AddToCart(productService);

                                            // Display Cart
                Console.WriteLine("\n===== CART =====");
                cartService.DisplayCart();

                                            // Bill
                cartService.CalculateBill();

                // Payment
                Console.WriteLine("\n===== PAYMENT =====");
                cartService.Payment();

                Console.WriteLine("\nThank You For Shopping!");
            }
            else
            {
                Console.WriteLine("\nLogin Failed.");
            }

            Console.ReadKey();
        }
    }
}