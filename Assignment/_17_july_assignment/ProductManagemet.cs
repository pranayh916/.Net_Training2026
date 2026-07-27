using System;
using System.Collections.Generic;
public class ProductManager

{
 List<Product> productList=new List<Product>();

        public void AddProduct()
    {
        Product p = new Product();


        Console.Write("Enter Product Id : ");
        p.ProductId = Convert.ToInt32(Console.ReadLine());

        foreach (Product pro in productList)
        {
            if (pro.ProductId == p.ProductId)
            {
                Console.WriteLine("Product Id Already Exists.");
                return;
            }
        }

        Console.Write("Enter Product Name : ");
        p.Name = Console.ReadLine();

        Console.Write("Enter Category : ");
        p.Category = Console.ReadLine();

        Console.Write("Enter Description : ");
        p.Description = Console.ReadLine();

        Console.Write("Enter Price : ");
        p.Price = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Quantity : ");
        p.Quantity = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Brand : ");
        p.Brand = Console.ReadLine();

        Console.Write("Enter Discount : ");
        p.Discount = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Rating : ");
        p.Rating = Convert.ToDouble(Console.ReadLine());

        productList.Add(p);

        Console.WriteLine("Product Added Successfully.");
    }    public void ViewAllProducts()
    {
        if (productList.Count == 0)
        {
            Console.WriteLine("No Products Available.");
            return;
        }

        foreach (Product p in productList)
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Product Id : " + p.ProductId);
            Console.WriteLine("Name : " + p.Name);
            Console.WriteLine("Category : " + p.Category);
            Console.WriteLine("Description : " + p.Description);
            Console.WriteLine("Price : " + p.Price);
            Console.WriteLine("Quantity : " + p.Quantity);
            Console.WriteLine("Brand : " + p.Brand);
            Console.WriteLine("Discount : " + p.Discount);
            Console.WriteLine("Rating : " + p.Rating);
        }
    }    public void SearchProduct()
    {
        Console.Write("Enter Product Id : ");
        int id = Convert.ToInt32(Console.ReadLine());

        foreach (Product p in productList)
        {
            if (p.ProductId == id)
            {
                Console.WriteLine("Product Found");
                Console.WriteLine("Name : " + p.Name);
                Console.WriteLine("Price : " + p.Price);
                Console.WriteLine("Quantity : " + p.Quantity);
                return;
            }
        }

        Console.WriteLine("Product Not Found.");
    }    public void UpdateProduct()
    {
        Console.Write("Enter Product Id : ");
        int id = Convert.ToInt32(Console.ReadLine());

        foreach (Product p in productList)
        {
            if (p.ProductId == id)
            {
                Console.Write("Enter New Price : ");
                p.Price = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter New Quantity : ");
                p.Quantity = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter New Discount : ");
                p.Discount = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter New Rating : ");
                p.Rating = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Product Updated Successfully.");
                return;
            }
        }

        Console.WriteLine("Product Not Found.");
    }    public void DeleteProduct()
    {
        Console.Write("Enter Product Id : ");
        int id = Convert.ToInt32(Console.ReadLine());

        foreach (Product p in productList)
        {
            if (p.ProductId == id)
            {
                productList.Remove(p);
                Console.WriteLine("Product Deleted Successfully.");
                return;
            }
        }

        Console.WriteLine("Product Not Found.");
    }
}
