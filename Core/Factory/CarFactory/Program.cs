namespace DevToolkit.Core.Factory.CarFactory;

class Program
{
    static void Main()
    {
        // Create a Car using Factory
        VehicleFactory carFactory = new CarFactory();
        IVehicle car = carFactory.CreateVehicle();
        car.Drive();

        // Create a Bike using Factory
        VehicleFactory bikeFactory = new BikeFactory();
        IVehicle bike = bikeFactory.CreateVehicle();
        bike.Drive();
    }
}

