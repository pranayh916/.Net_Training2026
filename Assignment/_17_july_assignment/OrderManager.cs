using System;
using System.Collections.Generic;

public class OrderManager
{
    List<Order> orderList = new List<Order>();

    public void AddOrder()
    {
        Order o = new Order();

        Console.Write("Enter Order Id : ");
        o.OrderId = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Customer Name : ");
        o.CustomerName = Console.ReadLine();

        Console.Write("Enter Amount : ");
        o.Amount = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Payment Method : ");
        o.PaymentMethod = Console.ReadLine();

        Console.Write("Enter Payment Status : ");
        o.PaymentStatus = Console.ReadLine();

        orderList.Add(o);

        Console.WriteLine("Order Saved Successfully.");
    }

    public void ViewOrders()
    {
        foreach (Order o in orderList)
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("Order Id : " + o.OrderId);
            Console.WriteLine("Customer : " + o.CustomerName);
            Console.WriteLine("Amount : " + o.Amount);
            Console.WriteLine("Payment : " + o.PaymentMethod);
            Console.WriteLine("Status : " + o.PaymentStatus);
        }
    }

    public void SearchOrder()
    {
        Console.Write("Enter Order Id : ");
        int id = Convert.ToInt32(Console.ReadLine());

        foreach (Order o in orderList)
        {
            if (o.OrderId == id)
            {
                Console.WriteLine("Order Found");
                Console.WriteLine("Customer : " + o.CustomerName);
                Console.WriteLine("Amount : " + o.Amount);
                Console.WriteLine("Payment : " + o.PaymentMethod);
                Console.WriteLine("Status : " + o.PaymentStatus);
                return;
            }
        }

        Console.WriteLine("Order Not Found.");
    }

    public void CancelOrder()
    {
        Console.Write("Enter Order Id : ");
        int id = Convert.ToInt32(Console.ReadLine());

        foreach (Order o in orderList)
        {
            if (o.OrderId == id)
            {
                orderList.Remove(o);
                Console.WriteLine("Order Cancelled.");
                return;
            }
        }

        Console.WriteLine("Order Not Found.");
    }

    public void DownloadInvoice()
    {
        Console.WriteLine("Invoice Downloaded Successfully.");
    }
}