using System;
using System.Linq;

using System.Collections.Generic;

class UserDefineException : Exception
{
    public UserDefineException(string msg) : base(msg)
    {
    }
}

class ItemNotFoundException : Exception
{
    public ItemNotFoundException(string msg) : base(msg)
    {
    }
}

class Stationery
{
    public int ItemId { get; set; }
    public string ItemName { get; set; }
    public string ItemCategory { get; set; }
    public double ItemPrice { get; set; }
    public string Brand { get; set; }

    private int itemQuantity;
    public int ItemQuantity
    {
        get { return itemQuantity; }
        set
        {
            if (value <= 0)
                throw new UserDefineException("Quantity must be greater than 0.");

            itemQuantity = value;
        }
    }

    List<Stationery> list_stationery = new List<Stationery>();

    // Add Item
    public void AddItem()
    {
        Stationery s = new Stationery();

        Console.Write("Enter Item Id: ");
        s.ItemId = Convert.ToInt32(Console.ReadLine());

        // Duplicate Id Check
        foreach (Stationery st in list_stationery)
        {
            if (st.ItemId == s.ItemId)
            {
                Console.WriteLine("Item ID Already Exists");
                return;
            }
        }

        Console.Write("Enter Item Name: ");
        s.ItemName = Console.ReadLine();

        Console.Write("Enter Category: ");
        s.ItemCategory = Console.ReadLine();

        Console.Write("Enter Price: ");
        s.ItemPrice = Convert.ToDouble(Console.ReadLine());

        if (s.ItemPrice < 0)
        {
            throw new UserDefineException("Price cannot be negative.");
        }

        Console.Write("Enter Quantity: ");
        s.ItemQuantity = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Brand: ");
        s.Brand = Console.ReadLine();

        list_stationery.Add(s);

        Console.WriteLine("Item Added Successfully.");
    }

    // Display
    public void DisplayItem()
    {
        if (list_stationery.Count == 0)
        {
            Console.WriteLine("No Items Available.");
            return;
        }

        foreach (Stationery s in list_stationery)
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine("Id       : " + s.ItemId);
            Console.WriteLine("Name     : " + s.ItemName);
            Console.WriteLine("Category : " + s.ItemCategory);
            Console.WriteLine("Price    : " + s.ItemPrice);
            Console.WriteLine("Quantity : " + s.ItemQuantity);
            Console.WriteLine("Brand    : " + s.Brand);
        }
    }

    // Search
    public void SearchItem()
    {
        Console.Write("Enter Item Id to Search: ");
        int id = Convert.ToInt32(Console.ReadLine());

        foreach (Stationery s in list_stationery)
        {
            if (s.ItemId == id)
            {
                Console.WriteLine("Item Found");
                Console.WriteLine("Name     : " + s.ItemName);
                Console.WriteLine("Category : " + s.ItemCategory);
                Console.WriteLine("Price    : " + s.ItemPrice);
                Console.WriteLine("Quantity : " + s.ItemQuantity);
                Console.WriteLine("Brand    : " + s.Brand);
                return;
            }
        }

        throw new ItemNotFoundException("Given Item not available.");
    }

    // Delete
    public void DeleteItem()
    {
        Console.Write("Enter Item Id to Delete: ");
        int id = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < list_stationery.Count; i++)
        {
            if (list_stationery[i].ItemId == id)
            {
                Console.WriteLine("Are you sure?");
                Console.WriteLine("1. Yes");
                Console.WriteLine("2. No");

                int ch = Convert.ToInt32(Console.ReadLine());

                if (ch == 1)
                {
                    list_stationery.RemoveAt(i);
                    Console.WriteLine("Item Deleted Successfully.");
                }
                else
                {
                    Console.WriteLine("Deletion Cancelled.");
                }
                return;
            }
        }

        throw new ItemNotFoundException("Given Item not available.");
    }

public void ItemSort()
{
    Console.WriteLine("1. Sort by Item ID");
    Console.WriteLine("2. Sort by Item Price");
    Console.WriteLine("3. Sort by Item Quantity");

    Console.Write("Enter your choice: ");
    int ch = Convert.ToInt32(Console.ReadLine());

    switch (ch)
    {
        case 1:
            list_stationery = list_stationery.OrderBy(x => x.ItemId).ToList();
            break;

        case 2:
            list_stationery = list_stationery.OrderBy(x => x.ItemPrice).ToList();
            break;

        case 3:
            list_stationery = list_stationery.OrderBy(x => x.ItemQuantity).ToList();
            break;

        default:
            Console.WriteLine("Invalid Choice");
            return;
    }

    Console.WriteLine("Items Sorted Successfully.");
    DisplayItem();
  }



    }


