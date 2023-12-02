namespace Abaxrekruttering;

public class Plane : Vehicle
{
    private readonly int _wingSpan;
    private readonly int _weightNoCargo;
    private readonly int _maxCargoWeight;

    public Plane(string registration, int effect, VehicleType vehicleType, int wingSpan, int weightNoCargo,
        int maxCargoWeight) : base(registration, effect, vehicleType)
    {
        _wingSpan = wingSpan;
        _weightNoCargo = weightNoCargo;
        _maxCargoWeight = maxCargoWeight;
    }

    public override void PrintInfo()
    {
        Console.WriteLine("Registration: " + Registration);
        Console.WriteLine("Effect: " + Effect);
        Console.WriteLine("Vehicle Type: " + VehicleType);
        Console.WriteLine("Wing Span: " + _wingSpan);
        Console.WriteLine("Weight without cargo: " + _weightNoCargo + "kg");
        Console.WriteLine("Max Cargo Weight: " + _maxCargoWeight);
        Console.WriteLine(new string('-', 10));
    }
}