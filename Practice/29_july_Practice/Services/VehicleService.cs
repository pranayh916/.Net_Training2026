using _29_july_Practice_2.Models;

namespace _29_july_Practice_2.Services
{

    public class VehicleService : IVehicleService
    {
        private static List<Vehicle> vehicles = new List<Vehicle>()
        {
            new Vehicle
            {
                Id = 101,
                Brand = "Honda",
                Model = "City",
                Color = "White",
                Price = 1200000
            },
            new Vehicle
            {
                Id = 101,
                Brand = "Honda",
                Model = "Amaze",
                Color = "Black",
                Price = 900000
            },
            new Vehicle
            {
                Id = 102,
                Brand = "Hyundai",
                Model = "Creta",
                Color = "Blue",
                Price = 1500000
            }
        };

        public List<Vehicle> getVehicle()
        {
            return vehicles;
        }

        public List<Vehicle> getVehicle(int id)
        {
            return vehicles.Where(v => v.Id == id).ToList();
        }

        public List<Vehicle> getVehicleBrand(string brand)
        {
            return vehicles.Where(v => v.Brand == brand).ToList();
        }

        public Vehicle addVehicle(Vehicle vehicle)
        {
            vehicles.Add(vehicle);
            return vehicle;
        }
    }

}
