using System;
class Program
{
  static void Main(string[] args)
    {
        Console.WriteLine("Name= Pranay");
        Console.WriteLine(" Branch:-Computer Science and Engineering");
         Console.WriteLine("College:-SSGMCE");

        Console.Write("Enter a number: ");
        string num = Console.ReadLine();

        Console.WriteLine("Value is: " + num);
       First p = new First();
       p.show();
    }
}

