using _29_july_Practice_2.Models;

namespace _29_july_Practice_2.Services
{
    public interface IVehicleService
    {
            List<Vehicle> getVehicle();
            List<Vehicle> getVehicle(int id);
            List<Vehicle> getVehicleBrand(string brand);
            Vehicle addVehicle(Vehicle vehicle);
    }

}

