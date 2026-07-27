using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingManagementSystem
{

       // Update Product Stock baki hai banana
       //return the first matching element linq ki method hai


    class ProductService
    {
        // Product List
        public List<Product> Products { get; set; }

        public ProductService()
        {
            Products = new List<Product>();
        }

                                                    // Add Products
        public void AddProducts()
        {
            Console.Write("How many products do you want to add? : ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Product p = new Product();

                Console.WriteLine("\nEnter Details of Product " + i);

                Console.Write("Enter Product ID : ");
                p.ProductId = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Product Name : ");
                p.ProductName = Console.ReadLine();

                Console.Write("Enter Price : ");
                p.Price = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter Stock : ");
                p.Stock = Convert.ToInt32(Console.ReadLine());

                Products.Add(p);

                Console.WriteLine("Product Added Successfully\n");
            }
        }

                                      // Display All Product
        public void DisplayProducts()
        {
            if (Products.Count == 0)
            {
                Console.WriteLine("No Products Available.");
                return;
            }

            Console.WriteLine("\n-----------------------------------------------");
            Console.WriteLine("ID\tName\t\tPrice\tStock");
            Console.WriteLine("-----------------------------------------------");

            foreach (Product p in Products)
            {
                Console.WriteLine($"{p.ProductId}\t{p.ProductName}\t\t{p.Price}\t{p.Stock}");
            }
        }

        // Search Product By Name
        public Product SearchProduct()
        {
            Console.Write("\nEnter Product Name to Search : ");
            string name = Console.ReadLine();

            Product product = Products.FirstOrDefault
            (
                p => p.ProductName.Equals(name, StringComparison.OrdinalIgnoreCase)
            );

            if (product != null)
            {
                Console.WriteLine("\nProduct Found");
                Console.WriteLine("-------------------------");
                Console.WriteLine("Product ID   : " + product.ProductId);
                Console.WriteLine("Product Name : " + product.ProductName);
                Console.WriteLine("Price        : " + product.Price);
                Console.WriteLine("Stock        : " + product.Stock);
            }
            else
            {
                Console.WriteLine("Product Not Found");
            }

            return product;
        }

        // Get Product By ID
        public Product GetProductById(int id)
        {
            return Products.FirstOrDefault(p => p.ProductId == id);
        }

        // Update Product Stock
        public void UpdateStock(Product product, int quantity)
        {
            if (product != null)
            {
                product.Stock -= quantity;
            }
        }
    }
}