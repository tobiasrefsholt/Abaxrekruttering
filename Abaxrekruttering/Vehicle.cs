namespace Abaxrekruttering;

public abstract class Vehicle
{
    protected string Registration;
    protected int Effect;
    protected VehicleType VehicleType;

    protected Vehicle(string registration, int effect, VehicleType vehicleType)
    {
        Registration = registration;
        Effect = effect;
        VehicleType = vehicleType;
    }

    public abstract void PrintInfo();
    
    public bool EqualsTo(Vehicle vehicle)
    {
        return Registration == vehicle.Registration
               && VehicleType == vehicle.VehicleType;
    }
}