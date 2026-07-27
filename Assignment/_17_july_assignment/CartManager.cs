using System;
using System.Collections.Generic;

public class CartManager
{
    List<Cart> cartList = new List<Cart>();

    public void AddToCart()
    {
        Cart c = new Cart();

        Console.Write("Enter Product Id : ");
        c.ProductId = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Product Name : ");
        c.ProductName = Console.ReadLine();

        Console.Write("Enter Price : ");
        c.Price = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Quantity : ");
        c.Quantity = Convert.ToInt32(Console.ReadLine());

        cartList.Add(c);

        Console.WriteLine("Product Added To Cart.");
    }

    public void ViewCart()
    {
        if (cartList.Count == 0)
        {
            Console.WriteLine("Cart is Empty.");
            return;
        }

        Console.WriteLine("\n===== CART =====");

        foreach (Cart c in cartList)
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Product Id : " + c.ProductId);
            Console.WriteLine("Product Name : " + c.ProductName);
            Console.WriteLine("Price : " + c.Price);
            Console.WriteLine("Quantity : " + c.Quantity);
        }
    }

    public void RemoveItem()
    {
        Console.Write("Enter Product Id : ");
        int id = Convert.ToInt32(Console.ReadLine());

        foreach (Cart c in cartList)
        {
            if (c.ProductId == id)
            {
                cartList.Remove(c);
                Console.WriteLine("Item Removed Successfully.");
                return;
            }
        }

        Console.WriteLine("Product Not Found.");
    }

    public void UpdateQuantity()
    {
        Console.Write("Enter Product Id : ");
        int id = Convert.ToInt32(Console.ReadLine());

        foreach (Cart c in cartList)
        {
            if (c.ProductId == id)
            {
                Console.Write("Enter New Quantity : ");
                c.Quantity = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Quantity Updated Successfully.");
                return;
            }
        }

        Console.WriteLine("Product Not Found.");
    }

    public void ClearCart()
    {
        cartList.Clear();
        Console.WriteLine("Cart Cleared Successfully.");
    }

    // View Total
    public void ViewTotal()
    {
        double total = 0;

        foreach (Cart c in cartList)
        {
            total += c.Price * c.Quantity;
        }

        double discount = total * 0.10;
        double gst = (total - discount) * 0.18;
        double grandTotal = (total - discount) + gst;

        Console.WriteLine("\n===== BILL =====");
        Console.WriteLine("Total : " + total);
        Console.WriteLine("Discount : " + discount);
        Console.WriteLine("GST : " + gst);
        Console.WriteLine("Grand Total : " + grandTotal);
    }

    // Apply Coupon
    public void ApplyCoupon()
    {
        Console.Write("Enter Coupon Code : ");
        string code = Console.ReadLine();

        if (code == "SAVE10")
        {
            Console.WriteLine("Coupon Applied Successfully.");
        }
        else
        {
            Console.WriteLine("Invalid Coupon.");
        }
    }
}