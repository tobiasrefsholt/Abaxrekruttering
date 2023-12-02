namespace Abaxrekruttering;

public class Boat : Vehicle
{
    private int _maxSpeed;
    private VelocityUnit _velocityUnit;
    private int _grossTonnage;
    public Boat(string registration, int effect, VehicleType vehicleType, int maxSpeed, VelocityUnit velocityUnit, int grossTonnage) : base(registration, effect, vehicleType)
    {
        _maxSpeed = maxSpeed;
        _velocityUnit = velocityUnit;
        _grossTonnage = grossTonnage;
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