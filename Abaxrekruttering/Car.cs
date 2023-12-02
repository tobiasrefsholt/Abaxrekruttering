namespace Abaxrekruttering;

class Car : Vehicle
{
    private readonly string _color;
    private readonly int _maxSpeed;
    private readonly VelocityUnit _velocityUnit;
    
    public Car(string registration, int effect, VehicleType vehicleType, string color, int maxSpeed, VelocityUnit velocityUnit) : base(registration, effect, vehicleType)
    {
        _color = color;
        _maxSpeed = maxSpeed;
        _velocityUnit = velocityUnit;
    }

    public override void PrintInfo()
    {
        Console.WriteLine("Registration: " + Registration);
        Console.WriteLine("Effect: " + Effect + " kw");
        Console.WriteLine("Vehicle Type: " + VehicleType);
        Console.WriteLine("Color: " + _color);
        Console.WriteLine("Max Speed: " + _maxSpeed + " " + _velocityUnit.GetDisplayName());
        Console.WriteLine(new string('-', 10));
    }
}