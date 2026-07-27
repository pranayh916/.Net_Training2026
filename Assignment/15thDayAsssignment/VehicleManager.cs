using System;
using System.Collections.Generic;
using System.Linq;


    class VehicleManager
    {
        List<Vehicle> vehicleList = new List<Vehicle>();

        public void AddVehicle()
        {
            Vehicle v = new Vehicle();

            Console.Write("Enter Vehicle ID : ");
            v.VehicleId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Vehicle Name : ");
            v.VehicleName = Console.ReadLine();

            Console.Write("Enter Vehicle Type : ");
            v.VehicleType = Console.ReadLine();

            Console.Write("Enter Brand : ");
            v.Brand = Console.ReadLine();

            Console.Write("Enter Price : ");
            v.Price = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Year : ");
            v.ManufacturingYear = Convert.ToInt32(Console.ReadLine());

            vehicleList.Add(v);

            Console.WriteLine("Vehicle Added Successfully.");
        }

        public void DisplayVehicles()
        {
            if (vehicleList.Count == 0)
            {
                Console.WriteLine("No Records Found.");
                return;
            }

            foreach (Vehicle v in vehicleList)
            {
                Console.WriteLine($"{v.VehicleId}\t{v.VehicleName}\t{v.Brand}\t{v.VehicleType}\t{v.Price}");
            }
        }

        public void SearchVehicle()
        {
            Console.Write("Enter Vehicle ID : ");
            int id = Convert.ToInt32(Console.ReadLine());

            Vehicle v = vehicleList.FirstOrDefault(x => x.VehicleId == id);

            if (v != null)
            {
                Console.WriteLine($"Name : {v.VehicleName}");//formate function 
                Console.WriteLine($"Brand : {v.Brand}");
                Console.WriteLine($"Price : {v.Price}");
            }
            else
            {
                Console.WriteLine("Vehicle Not Found");
            }
        }

        public void UpdatePrice()
        {
            Console.Write("Enter Vehicle ID : ");
            int id = Convert.ToInt32(Console.ReadLine());

            Vehicle v = vehicleList.FirstOrDefault(x => x.VehicleId == id);

            if (v != null)
            {
                Console.Write("Enter New Price : ");
                v.Price = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Price Updated Successfully.");
            }
            else
            {
                Console.WriteLine("Vehicle Not Found");
            }
        }

        public void DeleteVehicle()
        {
            Console.Write("Enter Vehicle ID : ");
            int id = Convert.ToInt32(Console.ReadLine());

            Vehicle v = vehicleList.FirstOrDefault(x => x.VehicleId == id);

            if (v != null)
            {
                vehicleList.Remove(v);
                Console.WriteLine("Vehicle Deleted Successfully.");
            }
            else
            {
                Console.WriteLine("Vehicle Not Found");
            }
        }

        public void CalculateDiscount()
        {
            Console.Write("Enter Vehicle ID : ");
            int id = Convert.ToInt32(Console.ReadLine());

            Vehicle v = vehicleList.FirstOrDefault(x => x.VehicleId == id);

            if (v == null)
            {
                Console.WriteLine("Vehicle Not Found");
                return;
            }

            double discount = 0;

            switch (v.VehicleType.ToLower())
            {
                case "car":
                    discount = v.Price * 0.10;
                    break;

                case "bike":
                    discount = v.Price * 0.05;
                    break;

                case "truck":
                    discount = v.Price * 0.12;
                    break;
            }

            Console.WriteLine("Price : " + v.Price);
            Console.WriteLine("Discount : " + discount);
            Console.WriteLine("Final Price : " + (v.Price - discount));
        }

        public void ShowVehicleDetails()
        {
            Console.Write("Enter Vehicle Type : ");
            string type = Console.ReadLine().ToLower();

            switch (type)
            {
                case "car":
                    Console.WriteLine("Car is a four wheeler.");
                    Console.WriteLine("Suitable for family.");
                    break;

                case "bike":
                    Console.WriteLine("Bike is fuel efficient.");
                    Console.WriteLine("Suitable for city rides.");
                    break;

                case "truck":
                    Console.WriteLine("Truck is used for transportation.");
                    Console.WriteLine("Heavy load vehicle.");
                    break;

                default:
                    Console.WriteLine("Invalid Vehicle Type.");
                    break;
            }
        }
    }
