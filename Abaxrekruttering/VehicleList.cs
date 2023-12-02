namespace Abaxrekruttering;

class VehicleList
{
    private List<Vehicle> _vehicles = new();

    public void AddVehicle(Vehicle vehicle)
    {
        _vehicles.Add(vehicle);
    }
}