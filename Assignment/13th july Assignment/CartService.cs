using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingManagementSystem
{
    class CartService
    {
        public List<CartItem> CartItems { get; set; }

        public CartService()
        {
            CartItems = new List<CartItem>();
        }

        public void AddToCart(ProductService productService)
        {
            int choice;

            do
            {
                Console.Write("\nEnter Product ID : ");
                int id = Convert.ToInt32(Console.ReadLine());

                Product product = productService.GetProductById(id);

                if (product != null)
                {
                    Console.Write("Enter Quantity : ");
                    int qty = Convert.ToInt32(Console.ReadLine());

                    if (qty <= product.Stock)
                    {
                        CartItem item = new CartItem();

                        item.ProductId = product.ProductId;
                        item.ProductName = product.ProductName;
                        item.Price = product.Price;
                        item.Quantity = qty;

                        CartItems.Add(item);

                        productService.UpdateStock(product, qty);

                        Console.WriteLine("Product Added To Cart Successfully.");
                    }
                    else
                    {
                        Console.WriteLine("Insufficient Stock.");
                    }
                }
                else
                {
                    Console.WriteLine("Product Not Found.");
                }

                Console.WriteLine("\n1. Yes");
                Console.WriteLine("2. No");
                Console.Write("Do you want to add another product? : ");
                choice = Convert.ToInt32(Console.ReadLine());

            } while (choice == 1);
        }

        public void DisplayCart()
        {
            if (CartItems.Count == 0)
            {
                Console.WriteLine("\nCart is Empty.");
                return;
            }

            Console.WriteLine("\n============= CART =============");
            Console.WriteLine("Name\t\tQty\tPrice\tTotal");

            foreach (CartItem item in CartItems)
            {
                Console.WriteLine($"{item.ProductName}\t\t{item.Quantity}\t{item.Price}\t{item.Total}");
            }
        }

        public double CalculateBill()
        {
            double total = CartItems.Sum(x => x.Total);

            double discount = 0;

            if (total >= 10000)
                discount = total * 0.30;
            else if (total >= 5000)
                discount = total * 0.20;
            else if (total >= 1000)
                discount = total * 0.10;

            double finalAmount = total - discount;

            Console.WriteLine("\n============= BILL =============");
            Console.WriteLine("Total Amount : " + total);
            Console.WriteLine("Discount     : " + discount);
            Console.WriteLine("Final Amount : " + finalAmount);

            return finalAmount;
        }

        public void Payment()
        {
            Console.WriteLine("\nChoose Payment Method");
            Console.WriteLine("1. UPI");
            Console.WriteLine("2. Credit Card");
            Console.WriteLine("3. Debit Card");
            Console.WriteLine("4. Cash On Delivery");

            Console.Write("Enter Choice : ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Payment Successful using UPI.");
                    break;

                case 2:
                    Console.WriteLine("Payment Successful using Credit Card.");
                    break;

                case 3:
                    Console.WriteLine("Payment Successful using Debit Card.");
                    break;

                case 4:
                    Console.WriteLine("Order Placed (Cash On Delivery).");
                    break;

                default:
                    Console.WriteLine("Invalid Payment Option.");
                    break;
            }
        }
    }
}