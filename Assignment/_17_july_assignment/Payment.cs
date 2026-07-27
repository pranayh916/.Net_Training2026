using System;

public class Payment : IPayment
{
    public void Pay()
    {
        Console.WriteLine("\n===== PAYMENT =====");
        Console.WriteLine("1. Credit Card");
        Console.WriteLine("2. Debit Card");
        Console.WriteLine("3. UPI");
        Console.WriteLine("4. Cash On Delivery");

        Console.Write("Select Payment Method : ");
        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.WriteLine("Payment Method : Credit Card");
                break;

            case 2:
                Console.WriteLine("Payment Method : Debit Card");
                break;

            case 3:
                Console.WriteLine("Payment Method : UPI");
                break;

            case 4:
                Console.WriteLine("Payment Method : Cash On Delivery");
                break;

            default:
                Console.WriteLine("Invalid Choice");
                return;
        }

        Console.WriteLine();
        Console.WriteLine("Payment Status");
        Console.WriteLine("1. Success");
        Console.WriteLine("2. Failed");
        Console.WriteLine("3. Pending");

        Console.Write("Enter Status : ");
        int status = Convert.ToInt32(Console.ReadLine());

        switch (status)
        {
            case 1:
                Console.WriteLine("Payment Successful.");
                break;

            case 2:
                Console.WriteLine("Payment Failed.");
                break;

            case 3:
                Console.WriteLine("Payment Pending.");
                break;

            default:
                Console.WriteLine("Invalid Status");
                break;
        }
    }
}