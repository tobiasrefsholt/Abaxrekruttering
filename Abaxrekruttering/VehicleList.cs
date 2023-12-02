using System.Text.Json;

namespace Abaxrekruttering;

class VehicleList
{
    private List<Vehicle> _vehicles = new();

    public void AddVehicle(Vehicle vehicle)
    {
        _vehicles.Add(vehicle);
    }

    public bool Compare(Vehicle vehicle1, Vehicle vehicle2)
    {
        return JsonSerializer.Serialize(vehicle1) == JsonSerializer.Serialize(vehicle2);
    }

    public bool Compare(int index1, int index2)
    {
        return Compare(_vehicles[index1], _vehicles[index2]);
    }

    public void ShowAll()
    {
        foreach (var vehicle in _vehicles)
        {
            vehicle.PrintInfo();
        }
    }
}