using System.Reflection.Metadata.Ecma335;
using System.Text.Json;

namespace Abaxrekruttering;

class VehicleList
{
    private List<Vehicle> _vehicles = new();

    public void AddVehicle(Vehicle vehicle)
    {
        _vehicles.Add(vehicle);
    }

    public Vehicle GetVehicle(int index)
    {
        return _vehicles[index];
    }

    public void ShowAll()
    {
        foreach (var vehicle in _vehicles)
        {
            vehicle.PrintInfo();
        }
    }

    public void AreEqual(Vehicle vehicle1, Vehicle vehicle2)
    {
        if (vehicle1.EqualsTo(vehicle2))
        {
            Console.WriteLine("Kjøretøyene er like");
            return;
        }
        Console.WriteLine("Kjøretøyene er ikke like");
    }

    public void AreEqual(int vehicle1, int vehicle2)
    {
        AreEqual(_vehicles[vehicle1], _vehicles[vehicle2]);
    }
}