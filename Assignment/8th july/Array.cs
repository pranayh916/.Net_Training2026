using System;
using System.Collections.Generic;

class Array
{
    public void Display_List()
    {
        List<string> l = new List<string>();

        l.Add("Pranay");
        l.Add("Aniket");
        l.Add("Chaitanya");
        l.Add("Atharva");
        l.Add("Lavish");

        foreach (string s in l)
        {
            Console.WriteLine(s);
        }
    }
}