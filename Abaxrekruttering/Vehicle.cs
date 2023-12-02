namespace Abaxrekruttering;

public abstract class Vehicle
{
    protected string Registration;
    protected int Effect;
    protected int MaxSpeed;
    protected string Color;
    protected VelocityUnit VelocityUnit;
    protected VehicleType VehicleType;

    protected Vehicle(string registration, int effect, int maxSpeed, string color, VelocityUnit velocityUnit,
        VehicleType vehicleType)
    {
        Registration = registration;
        Effect = effect;
        MaxSpeed = maxSpeed;
        Color = color;
        VelocityUnit = velocityUnit;
        VehicleType = vehicleType;
    }

    protected abstract void PrintInfo();
}