using System;
using System.Collections.Generic;

public class CategoryManager
{
    List<Category> categoryList = new List<Category>();

    public CategoryManager()
    {
        categoryList.Add(new Category { CategoryId = 1, CategoryName = "Electronics" });
        categoryList.Add(new Category { CategoryId = 2, CategoryName = "Books" });
        categoryList.Add(new Category { CategoryId = 3, CategoryName = "Fashion" });
        categoryList.Add(new Category { CategoryId = 4, CategoryName = "Sports" });
        categoryList.Add(new Category { CategoryId = 5, CategoryName = "Furniture" });
        categoryList.Add(new Category { CategoryId = 6, CategoryName = "Groceries" });
    }
        public void AddCategory()
    {
        Category c = new Category();

        Console.Write("Enter Category Id : ");
        c.CategoryId = Convert.ToInt32(Console.ReadLine());

        foreach (Category cat in categoryList)
        {
            if (cat.CategoryId == c.CategoryId)
            {
                Console.WriteLine("Category Id Already Exists.");
                return;
            }
        }

        Console.Write("Enter Category Name : ");
        c.CategoryName = Console.ReadLine();

        categoryList.Add(c);

        Console.WriteLine("Category Added Successfully.");
    }
        public void ViewCategory()
    {
        Console.WriteLine("\n===== CATEGORY LIST =====");

        foreach (Category c in categoryList)
        {
            Console.WriteLine(c.CategoryId + "  " + c.CategoryName);
        }
    }
        public void UpdateCategory()
    {
        Console.Write("Enter Category Id : ");
        int id = Convert.ToInt32(Console.ReadLine());

        foreach (Category c in categoryList)
        {
            if (c.CategoryId == id)
            {
                Console.Write("Enter New Category Name : ");
                c.CategoryName = Console.ReadLine();

                Console.WriteLine("Category Updated Successfully.");
                return;
            }
        }

        Console.WriteLine("Category Not Found.");
    }
        public void DeleteCategory()
    {
        Console.Write("Enter Category Id : ");
        int id = Convert.ToInt32(Console.ReadLine());

        foreach (Category c in categoryList)
        {
            if (c.CategoryId == id)
            {
                categoryList.Remove(c);
                Console.WriteLine("Category Deleted Successfully.");
                return;
            }
        }

        Console.WriteLine("Category Not Found.");
    }
}