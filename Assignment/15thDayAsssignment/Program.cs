using System;

    class Program
    {
        static void Main(string[] args)
        {
            VehicleManager manager = new VehicleManager();
            Console.WriteLine("=====Welcome to Employee page======");
            Console.WriteLine("Enter Employee Name : ");
            string name = Console.ReadLine();

            Console.Write("Enter Employee ID : ");
            string id = Console.ReadLine();

            Console.WriteLine("\nWelcome " + name);

            int choice;

            do
            {
                Console.WriteLine("\n1.Add Vehicle");
                Console.WriteLine("2.View All Vehicles");
                Console.WriteLine("3.Search Vehicle");
                Console.WriteLine("4.Update Vehicle Price");
                Console.WriteLine("5.Delete Vehicle");
                Console.WriteLine("6.Calculate Discount");
                Console.WriteLine("7.Show Vehicle Details");
                Console.WriteLine("8.Exit");

                Console.Write("Enter Choice : ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        manager.AddVehicle();
                        break;

                    case 2:
                        manager.DisplayVehicles();
                        break;

                    case 3:
                        manager.SearchVehicle();
                        break;

                    case 4:
                        manager.UpdatePrice();
                        break;

                    case 5:
                        manager.DeleteVehicle();
                        break;

                    case 6:
                        manager.CalculateDiscount();
                        break;

                    case 7:
                        manager.ShowVehicleDetails();
                        break;

                    case 8:
                        Console.WriteLine("Thank You...");
                        break;

                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }

            } while (choice != 8);
        }
    }
