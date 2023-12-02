namespace Abaxrekruttering;

public class Plane : Vehicle
{
    public Plane(string registration, int effect, int maxSpeed, string color, VelocityUnit velocityUnit,
        VehicleType vehicleType) : base(registration, effect, maxSpeed, color, velocityUnit, vehicleType)
    {
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