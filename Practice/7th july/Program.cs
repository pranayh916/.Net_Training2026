using System;

class Program
{
    static void Main()
    {
        Street_Light s=new Street_Light(); 
        s.show();
        Console.WriteLine("-----------------------------------------------------Next Program Outpur---------------------------------------------------------");
        Conveyor c=new Conveyor();
        c.light();
    }
}