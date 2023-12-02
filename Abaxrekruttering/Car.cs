namespace Abaxrekruttering;

class Car : Vehicle
{
    protected string Color;
    protected int MaxSpeed;
    protected VelocityUnit VelocityUnit;
    
    public Car(string registration, int effect, VehicleType vehicleType, string color, int maxSpeed, VelocityUnit velocityUnit) : base(registration, effect, vehicleType)
    {
        Color = color;
        MaxSpeed = maxSpeed;
        VelocityUnit = velocityUnit;
    }

    protected override void PrintInfo()
    {
        throw new NotImplementedException();
    }

    public void Drive()
    {
        throw new NotImplementedException();
    }

}