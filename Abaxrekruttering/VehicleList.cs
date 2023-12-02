using System.Text.Json;

namespace Abaxrekruttering;

class VehicleList
{
    private List<Vehicle> _vehicles = new();

    public void AddVehicle(Vehicle vehicle)
    {
        _vehicles.Add(vehicle);
    }

    public void ShowAll()
    {
        foreach (var vehicle in _vehicles)
        {
            vehicle.PrintInfo();
        }
    }
}