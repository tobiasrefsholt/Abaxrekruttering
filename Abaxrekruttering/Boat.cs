namespace Abaxrekruttering;

public class Boat : Vehicle
{
    private readonly int _maxSpeed;
    private readonly VelocityUnit _velocityUnit;
    private readonly int _grossTonnage;

    public Boat(string registration, int effect, VehicleType vehicleType, int maxSpeed, VelocityUnit velocityUnit,
        int grossTonnage) : base(registration, effect, vehicleType)
    {
        _maxSpeed = maxSpeed;
        _velocityUnit = velocityUnit;
        _grossTonnage = grossTonnage;
    }

    public override void PrintInfo()
    {
        Console.WriteLine("Registration: " + Registration);
        Console.WriteLine("Effect: " + Effect);
        Console.WriteLine("Vehicle Type: " + VehicleType);
        Console.WriteLine("Max Speed: " + _maxSpeed + _velocityUnit);
        Console.WriteLine("Gross Tonnage: " + _grossTonnage);
        Console.WriteLine(new string('-', 10));
    }
}