using System;
using System.Collections.Generic;

class Library
{
    public  void show_books()
    {
        List<string> books = new List<string>();

        books.Add("Java");
        books.Add("C");
        books.Add("Python");
        books.Add("DBMS");

        Console.WriteLine("Available Books:");
        foreach (string book in books)
        {
            Console.WriteLine(book);
        }

        books.Add("C#");

        books.Remove("C");

        Console.WriteLine("\nUpdated Book List:");
        foreach (string book in books)
        {
            Console.WriteLine(book);
        }

        Console.WriteLine("\nTotal Books = " + books.Count);
    }
}